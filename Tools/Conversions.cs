using Aspose.Cells;             //needed for WorkBooks
using Aspose.Cells.Utility;     //needed for JsonUtility

namespace Conversions{

public class ConversionsO{
 
    public void saveCsvFileFromJsonString(string inputJsonString, string csvPath,string fileName){
            var workbook = new Workbook();
            var worksheet = workbook.Worksheets[0];
            var layoutOptions = new JsonLayoutOptions();
            layoutOptions.ArrayAsTable = true;
            JsonUtility.ImportData(inputJsonString, worksheet.Cells,0,0, layoutOptions);
            workbook.Save(csvPath + "\\" + fileName, SaveFormat.Csv);
    }
}
}