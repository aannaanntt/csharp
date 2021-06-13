using FirstCSharp.Math;
using System;
using System.Collections.Generic;
using FirstCSharp.Conditionals;
using System.Text;
using System.IO;

namespace FirstCSharp
{

    class Program
    {
        static void Main(string[] arg)
        {
            // var person = new Person();

            //person.FirstName = "Anant";
            //person.LastName = "Mishra";
            // person.Introduce();
            //var cal = new Calculator();
            // var g=cal.Add(2, 5);
            //Console.WriteLine(g);

            //   var num = new int[3];
            //  num[0] = 1;
            //num[1] = 2;
            //num[2] = 3;

            //Console.WriteLine(num[0]);
            //Console.WriteLine(num[1]);
            // Console.WriteLine(num[2]);

            //  var flags = new bool[3];
            //flags[0] = true;
            //Console.WriteLine(flags[0]);
            //Console.WriteLine(flags[1]);
            // Console.WriteLine(flags[2]);

            // var names = new string[3] { "jack", "john", "Mary" };
            //Console.WriteLine(names);


            ///   var firstName = "Anant";
            //var lastName = "Mishra";
            //var fullName = firstName + " " + lastName;
            //var myFullName = string.Format("My name is {0} {1}",firstName,lastName);
            //var names = new string[3]{ "John","Jack","Mary"};
            //var formattedNames = string.Join(",",names);
            // Console.WriteLine(myFullName);
            // Console.WriteLine(formattedNames);

            // var text = @"Hi John  Look into the path 
            //               c:\folder1\folder2
            //             c:\folder3\folder4";
            //Console.WriteLine(text);



            //   var method = Shipping.Express;
            // Console.WriteLine((int)method);


            //var methodId = 3;
            // Console.WriteLine((Shipping)methodId);

            //Console.WriteLine(method.ToString());
            //how to convert string to Enum in c#

            //var methodName = "Express";
            //var shippings = (Shipping)Enum.Parse(typeof(Shipping), methodName);


            //  var a = 10;
            //var b = a;
            //b++;
            //   Console.WriteLine(string.Format("a :{0},b:{1}",a,b));

            // var array1 = new int[3] { 1, 2, 3 };
            //var array2 = array1;
            //array2[0] = 0;
            // Console.WriteLine("array1[0] :{0},array2[0]: {1}",array1[0],array2[0]);

            //bool isGoldCustomer = true;
            //float price;
            //if (isGoldCustomer) {
            //  price = 19.95f;

            //}
            // else {
            //   price = 29.95f;

            //}

            // float price = (isGoldCustomer) ? 19.95f : 29.59f;
            //  Console.WriteLine(price);


            //  var season = Season.Autum;

            //   switch (season)
            //   {

            //    case Season.Autum: {
            //      Console.WriteLine("You are promoted");
            //      break;
            //            
            //    }
            // case Season.Summer: {
            //   Console.WriteLine("Summer");
            //     break;

            //  }
            //default: {
            // Console.WriteLine("I dont understand");
            //  break;

            // }

            // for (var i = 1; i <= 10; i++) {
            //    if (i % 2 == 0) {
            //      Console.WriteLine(i);

            // }

            //}

            // for (var i=10;i>=1;i--) {
            //   if(i%2==0)
            // Console.WriteLine(i);


            //}


            // var name = "Anant";
            //for (var i=0;i< name.Length;i++) {
            //Console.Write(name[i]);


            //}
            //  foreach(var character in name)
            //    {
            //  Console.WriteLine(character);
            //  }

            //while (true)
            //{
            //  Console.Write("Type ypur name");
            // var input=Console.ReadLine();

            //  if (!String.IsNullOrWhiteSpace(input))
            //  {
            //   Console.WriteLine("@Echo:" + input);
            //   continue;
            //    }

            //  break;
            // const int pass = 10;
            //   var random = new Random();
            //   var buffer = new char[pass];

            //   for(var i = 0; i < pass; i++)
            //   
            //   buffer[i]=(char)('a'+random.Next(0,26));
            //     var password = new string(buffer);
            //     Console.WriteLine(password);

            //    var numbers = new[] { 3, 7, 8, 9, 0, 7, 5 };

            //Length
            //   Console.WriteLine(numbers.Length);


            //IndexOf()
            //  var index = Array.IndexOf(numbers, 9);
            //  Console.WriteLine(index);

            //Clear()
            //Array.Clear(numbers, 0, 2);

            //foreach (var num in numbers)
            // {
            //   Console.WriteLine(num);
            //}

            //var another = new int[3];
            //Copy
            //Console.WriteLine("copy");
            //Array.Copy(numbers, another, another.Length);

            //      foreach (var n in another)
            //        {

            //              Console.WriteLine(n);
            //            }

            //Sort

            //  Console.WriteLine("sort method");
            //  Array.Sort(another);
            //  foreach(var n in another)
            //   {
            //       Console.WriteLine(n);
            //   }

            //reverse
            //   Console.WriteLine("reverse");
            //   Array.Reverse(another);
            //   foreach(var num in another)
            //      Console.WriteLine(num);


            //Lists
            // var numbers = new List<int>() { 1,2,3,4};
            //  numbers.Add(1);
            //  numbers.AddRange(new int[3] { 5,6,7});


            //  foreach(var number in numbers)
            //   {
            //      Console.WriteLine(number);
            //  }
            //   Console.WriteLine();
            //   Console.WriteLine(numbers.IndexOf(1));
            //   Console.WriteLine();
            //   Console.WriteLine(numbers.LastIndexOf(1));

            //  Console.WriteLine();
            //  Console.WriteLine(numbers.Count);
            //   numbers.Remove(1);


            //  foreach (var number in numbers)
            //  {
            // //     Console.WriteLine(number);
            //  }
            // Console.WriteLine("Remove method");
            //for(var i = 0; i < numbers.Count; i++)
            //  {
            //   if (numbers[i] == 1)
            // {
            // numbers.Remove(numbers[i]);
            //  }

            //  }
            //  foreach (var num in numbers)
            //  {
            //     Console.WriteLine(num);
            // }
            // Console.WriteLine("clear");
            // numbers.Clear();
            //   var dateTime = new DateTime(2015, 1, 1);
            //   var now= DateTime.Now;
            //   Console.WriteLine(now);
            //   var today=DateTime.Today;

            ////   Console.WriteLine("Hour"+now.Hour);
            // Console.WriteLine("Minute"+now.Minute);

            // var tommorow=now.AddDays(1);
            // var yesterday = now.AddDays(-1);
            //  Console.WriteLine(now.ToString());
            //  Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            //  var timeSpan = new TimeSpan(1,2,3);
            //  var timeSpan1 = new TimeSpan(1, 0, 0);
            //  var timeSpan2 = TimeSpan.FromHours(1);
            //   Console.WriteLine(timeSpan2);

            //  var start = DateTime.Now;
            //  var end = DateTime.Now.AddMinutes(2);
            //  var duration = end - start;

            //  Console.WriteLine("Duration : {0}",duration);


            //Properties

            //  Console.WriteLine("Minutes :"+timeSpan.Minutes);
            //  Console.WriteLine("Total Minutes :"+timeSpan.TotalMinutes );

            //Add
            //  Console.WriteLine("Add Example"+ timeSpan.Add(TimeSpan.FromMinutes(8)));
            //  Console.WriteLine("Sub Example" + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString

            //  Console.WriteLine("ToString"+timeSpan.ToString());
            //Timne span object
            //  Console.WriteLine("Parse"+TimeSpan.Parse("01:02:03"));

            // var fullName = "Anant Mishra ";
            // Console.WriteLine("Trim: '{0}' ",fullName.Trim());
            //         Console.WriteLine("Trim: '{0}' ",fullName.Trim().ToUpper());
            //  var index = fullName.IndexOf(' ');
            //  var firstName = fullName.Substring(0,index);
            //  var lastName = fullName.Substring(index + 1);
            //  Console.WriteLine(firstName +" "+ lastName);

            //  var names=  fullName.Split(' ');
            ///  Console.WriteLine("firstname:"+names[0]);
            // Console.WriteLine("lastname"+names[1]);

            //  Console.WriteLine(fullName.Replace("Anant", "Vasu"));

            //   if (String.IsNullOrEmpty(" ".Trim()))
            //   {
            //      Console.WriteLine("Invalid ");
            //  }


            //  var str = "25";
            // var age= Convert.ToByte(str);
            //  Console.WriteLine(age);

            //  float price = 29.59f;
            //  Console.WriteLine(price.ToString("C0"));

            //   var sentence = " this is going to be ver very very very very long text";
            //  const int maxLength = 20;
            //  if(sentence.Length<maxLength)
            //  {
            //      Console.WriteLine(sentence);
            //  }
            //   else
            //  {
            //     var words = sentence.Split(' ');
            //     var totalChar = 0;
            //     var summarywords = new List<string>();
            //     foreach(var word in words)
            //    {
            //        summarywords.Add(word);
            //     totalChar += word.Length+1;
            //    if (totalChar > maxLength)
            //     {
            //         break;
            //      }
            //   }
            //
            //   var summary=String.Join(" ",summarywords)+  "...";
            //  Console.WriteLine(summary);
            // }


            // var builder = new StringBuilder("Hello world");

            //  builder.Append('-', 10)
            // .AppendLine()
            //  .Append("Header")
            //  .AppendLine()
            // .Append('-', 10)

            // .Replace('-', '+')
            /// .Remove(0, 10)
            //  .Insert(0, new string('-', 10));
            //  Console.WriteLine(builder);
            //  Console.WriteLine("first char"+builder[0]);
            //   var path = @"c:\somefile.jpg";
            //  File.Copy(@"c:\temp\myfile.jpg","d:\temp\myfile.jpg",true);
            //  File.Delete(path);
            //  if(File.Exists(path))
            // // {
            //
            //  }
            // var content=File.ReadAllText(path);


            //  var fileInfo = new FileInfo(path);
            //  fileInfo.CopyTo("...");
            //  fileInfo.Delete();
            //  if (fileInfo.Exists)
            //  {
            //
            // }

            // Directory.CreateDirectory(@"c:\temp\folder1");
            // var files=  Directory.GetFiles(@"c:\projects\cSharpFundamentals","*.*",SearchOption.AllDirectories);
            // foreach(var file in files)
            //   Console.WriteLine(file);

            //var directories = Directory.GetDirectories(@"c:\temp\folder1","*.",SearchOption.AllDirectories);

            // foreach(var dir in directories)
            // Console.WriteLine(dir);

            //  Directory.Exists("...");
            //  var directoryInfo = new DirectoryInfo("...");
            //  directoryInfo.GetFiles();
            //  directoryInfo.GetDirectories();

            //var path = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";
            //  var dotIndex = path.IndexOf('.');
            //  var extendion = path.Substring(dotIndex);
            // Console.WriteLine("Extension : "+Path.GetExtension(path));

            string str = ""; string reverse = "";
            int length = 0;
            Console.WriteLine("Enter a word");
            str = Console.ReadLine();
            length = str.Length - 1;
            while (length >= 0)
            {
                reverse = reverse + str[length];
                length--;

            }
            Console.WriteLine("Reverse  is {0}",reverse);
        
        }

        
    }
}


        


        



      


        
    

 
