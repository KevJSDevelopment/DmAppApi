using DMApp.Dtos;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.AcroForms;
using PdfSharpCore.Pdf.IO;

namespace DMApp
{
    public class FileHelper
    {
        public static async Task<string> FillFormAsync(CharacterReadDto characterReadDto)
        {
            var formUrl = "https://pdf-lib.js.org/assets/dod_character.pdf";

            using var formStream = await new HttpClient().GetStreamAsync(formUrl);

            var document = PdfReader.Open(formStream);

            var form = document.AcroForm;

            var nameField = (PdfTextField)form.Fields["CharacterName 2"];
            var ageField = (PdfTextField)form.Fields["Age"];
            var heightField = (PdfTextField)form.Fields["Height"];
            var weightField = (PdfTextField)form.Fields["Weight"];
            var eyesField = (PdfTextField)form.Fields["Eyes"];
            var skinField = (PdfTextField)form.Fields["Skin"];
            var hairField = (PdfTextField)form.Fields["Hair"];

            var alliesField = (PdfTextField)form.Fields["Allies"];
            var factionField = (PdfTextField)form.Fields["FactionName"];
            var backstoryField = (PdfTextField)form.Fields["Backstory"];
            var traitsField = (PdfTextField)form.Fields["Feat+Traits"];
            var treasureField = (PdfTextField)form.Fields["Treasure"];

            var characterImageButton = (PdfButtonField)form.Fields["CHARACTER IMAGE"];
            var factionImageButton = (PdfButtonField)form.Fields["Faction Symbol Image"];

            nameField.Value = new PdfString(characterReadDto.Name);
            /*ageField.Value = new PdfString($"{characterReadDto.Age} years");
            heightField.Value = new PdfString(characterReadDto.Height);
            weightField.Value = new PdfString($"{characterReadDto.Weight} lbs");
            eyesField.Value = new PdfString(characterReadDto.Eyes);
            skinField.Value = new PdfString(characterReadDto.Skin);
            hairField.Value = new PdfString(characterReadDto.Hair);

            var backStoryArray = characterReadDto.Background.Split(". ");
            backstoryField.Value = new PdfString(string.Join("\n", backStoryArray));
            */

            var pdfDocumentStream = new System.IO.MemoryStream();
            document.Save(pdfDocumentStream, closeStream: false);

            var pdfDataUri = "data:application/pdf;base64," + System.Convert.ToBase64String(pdfDocumentStream.ToArray());

            return pdfDataUri;
        }

    }
}