using Task3;

{
    static void Main(string[] args)
    {       
        string filePath = "sample.txt";
                
        CreateSampleFile(filePath);
                
        FileReader reader = new FileReader();
        reader.Read(filePath);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static void CreateSampleFile(string filePath)
    {
        
        string content = "This is a sample text file for Task3. ";
        content +="these stated goals sound impressive. They literally set expectations among the citizens.";
        content += "The new government’s priorities following the election should be determined by its development philosophy.";
                
    }
}