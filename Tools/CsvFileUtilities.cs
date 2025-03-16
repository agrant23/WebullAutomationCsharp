namespace CsvFileUtilities;

public class CsvFileUtilitiesO
{
//Method reads a csv file from the provided filePath, and searches each cell for the provided
//searchTerm. This method is usefull if there is a static record in a cell and the desired record
//is in the cell next to it. This method is easily editable to grab other records.
    public string SearchCsvFileCells(string filePath,string searchTerm)
    {
        try
        {
            string[] lineArray = File.ReadAllLines(@filePath);

            for(int i = 0; i < lineArray.Length; i++)
            {  //itterates through each line of the sheet
                string[] line = lineArray[i].Split(','); //split's the sheet into lines, where each line is an array of cells
                for(int j = 0; j < line.Length; j++)
                {  //itterates through each cell of a line
                    string cell = line[j];
                    if(cell == searchTerm)
                    {
                        return line[j+1];
                    }      
                }
            }
        }
        catch(FileNotFoundException)
        {
            return $"{filePath} could not be found";
            throw new FileNotFoundException ($"{filePath} could not be found");
        }
        return $"No cell matches {searchTerm}";
    }
}
