using Newtonsoft.Json;

namespace Day10
{

    /*
        ╔══════════╗ 
        ║ File I/O ║
        ╚══════════╝ 

        3 things are required for File I/O:
        1) Open the file
        2) read/write to the file
        3) close the file


        TIPS:
            use File.ReadAllText to open,read,close the file in 1 statement
            the using() statement can ensure that the file is closed

    */
    public enum Powers
    {
        Money, Jumping, Speed, Strength, Swimming
    }
    class Superhero
    {
        public string Name { get; set; }
        public string Secret { get; set; }
        public Powers Power { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                ╔══════════╗ 
                ║ File I/O ║
                ╚══════════╝ 

                [  Open the file  ]
                [  Write to the file  ]
                [  Close the file  ]
             
                you need the path to the file
                    use full path ( drive + directories + filename )
                    or use relative path ( directories + filename )
                    or current directory ( filename )


                
                using (StreamWriter sw = new StreamWriter(filePath)) // this line opens the file to write to it
                {                
                    //these lines write to the file
                    sw.Write("Batman");
                    sw.Write(54);
                    sw.Write(13.7);
                    sw.Write(true);

                }//this closes the file

            */

            string directories = @"C:\temp\2308"; //use @ in front of the string to ignore escape sequences inside the string
            string fileName = "sample.txt";
            string filePath = Path.Combine(directories, fileName); //use Path.Combine to get the proper directory separators

            char delimiter = '*';
            if (Directory.Exists(directories))
            {
                using (StreamWriter sw = new StreamWriter(filePath)) //IDisposable
                {
                    sw.Write("Batman rules. Aquaman drools.");
                    sw.Write(delimiter);
                    sw.Write(5);
                    sw.Write(delimiter);
                    sw.Write(420);
                    sw.Write(delimiter);
                    sw.Write(13.7);
                    sw.Write(delimiter);
                    sw.Write(true);
                }
            }
            else
                Console.WriteLine($"ERROR: {directories} does not exists.");
            /*
                CHALLENGE 1:
                    Create a List of Superhero.
                    Write the list to a CSV file             
            */
            List<Superhero> dc = new();
            dc.Add(new Superhero() { Name = "Batman", Secret = "Bruce Wayne", Power = Powers.Money });
            dc.Add(new Superhero() { Name = "Flash", Secret = "Barry Allen", Power = Powers.Speed });
            dc.Add(new Superhero() { Name = "Wonder Woman", Secret = "Diana Prince", Power = Powers.Strength });
            dc.Add(new Superhero() { Name = "Aquaman", Secret = "Arthur Curry", Power = Powers.Swimming });

            string heroFile = "dc.csv";
            string heroFilePath = Path.Combine(directories, heroFile);
            if (Directory.Exists(directories))
            {
                using (StreamWriter sw = new StreamWriter(heroFilePath))
                {
                    foreach (var hero in dc)
                    {
                        //2 delimiters: * inside the hero info and \n to separate the heroes
                        sw.WriteLine($"{hero.Name}{delimiter}{hero.Secret}{delimiter}{hero.Power}");
                    }
                }
            }
            else
                Console.WriteLine($"ERROR: {directories} does not exists.");


            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        string[] lineData = line.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                        string text = lineData[0];
                        int num = int.Parse(lineData[1]);
                        int favHoliday = int.Parse(lineData[2]);
                        double grade = double.Parse(lineData[3]);
                        bool gonnaPass = bool.Parse(lineData[4]);
                    }
                }
            }
            /*
                ╔═══════════════════╗ 
                ║ Splitting Strings ║
                ╚═══════════════════╝ 
                taking 1 string a separating it into multiple pieces of data
                use the string's Split method
            */
            string csvString = "Batman;Bruce Wayne;Bats;The Dark Knight";
            string[] data = csvString.Split(';');
            /*
                CHALLENGE 2:
                    Open the CSV file and read the data into a new list of superheroes             
            */
            List<Superhero> otherDC = new();
            if (File.Exists(heroFilePath))
            {
                //using (StreamReader sr = new StreamReader(heroFilePath))
                //{
                //    string line;
                //    while ((line = sr.ReadLine()) != null)//split the data to get each hero line
                //    {
                //        string[] heroData = line.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                //        otherDC.Add(new Superhero()
                //        {
                //            Name = heroData[0],
                //            Secret = heroData[1],
                //            Power = Enum.Parse<Powers>(heroData[2])
                //        });
                //    }
                //}
                //OR, read the whole file into a string then process the string
                string heroText = File.ReadAllText(heroFilePath);  //opens, reads, closes the file
                string[] heroArray = heroText.Split('\n', StringSplitOptions.RemoveEmptyEntries);
                foreach (string heroLine in heroArray)
                {
                    string[] heroData = heroLine.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                    otherDC.Add(new Superhero()
                    {
                        Name = heroData[0],
                        Secret = heroData[1],
                        Power = Enum.Parse<Powers>(heroData[2])
                    });
                }
                foreach (var hero in otherDC)
                {
                    Console.WriteLine($"Hello citizen. I am {hero.Name} (aka {hero.Secret}). I can do {hero.Power}!");
                }
            }





            /*
                ╔═════════════╗ 
                ║ Serializing ║
                ╚═════════════╝ 

                Saving the state (data) of objects

            */

            Superhero superhero = new Superhero() { Name = "Aquaman", Secret = "Arthur Curry", Power = Powers.Swimming };
            string aquaFile = "Aquaman.json";
            string aquaFilePath = Path.Combine(directories, aquaFile);
            if (Directory.Exists(directories))
            {
                //using (StreamWriter sw = new StreamWriter(aquaFilePath))
                //{
                //    using (JsonTextWriter jtw = new JsonTextWriter(sw))
                //    {
                //        JsonSerializer serializer = new JsonSerializer();
                //        serializer.Formatting = Formatting.Indented;
                //        serializer.Serialize(jtw, superhero);
                //    }
                //}

                File.WriteAllText(aquaFilePath, JsonConvert.SerializeObject(superhero, Formatting.Indented)); 
            }
            else
                Console.WriteLine($"ERROR: {directories} does not exists.");


            /*
             * Challenge 3:
                Serialize (write) the list of superheroes to a json file
            */






            /*
                ╔═══════════════╗ 
                ║ Deserializing ║
                ╚═══════════════╝ 

                Recreating the objects from the saved state (data) of objects

            */



            /*
             
                Challenge 4: deserialize the jla.json file into a list of superheroes

            */
        }
    }
}