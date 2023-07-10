using System;
//using System.Collections.Concurrent;
//using System.Net.NetworkInformation;

// tambah library
using System.Collections.Generic;


public class Program
{
    static void Menu()
    {
        Console.WriteLine("==============================");
        Console.WriteLine("Menu Collection");
        Console.WriteLine("==============================");
        Console.WriteLine("1. Contoh List");
        Console.WriteLine("2. Contoh Dictionary");
        Console.WriteLine("3. Contoh Queue");
        Console.WriteLine("4. Contoh Stack");
        Console.WriteLine("5. Contoh SortedList");
        Console.WriteLine("6. Exit");
        Console.WriteLine("==============================");
    }

    // LIST
    static void List()
    {
        Console.WriteLine("CONTOH LIST");
        // Deklarasi dan inisialisasi list
        List<string> names = new List<string> {"Sherin"};
        // Menambahkan elemen ke list
        names.Add("Budi"); 
        names.Add("Pakdi"); 
        names.Add("Dedi");
        Console.WriteLine("Menambah Add()");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Mengubah elemen list
        names[1] = "Devina";
        Console.WriteLine();
        Console.WriteLine("Mengubah");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Menyisipkan elemen list
        names.Insert(1, "Irvan");
        Console.WriteLine();
        Console.WriteLine("Menyisipkan Insert()");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Menghapus elemen list
        names.Remove("Dedi");
        Console.WriteLine();
        Console.WriteLine("Menghapus Remove()");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Mengihitung jumlah list
        int jumlahElemen = names.Count;
        Console.WriteLine();
        Console.WriteLine("Mengitung Count");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("Jumlah elemen list adalah : " + jumlahElemen);

        // Mengecek apakah elemen tertentu ada dalam list
        Console.WriteLine();
        Console.WriteLine("Cek/Cari Contains()");
        bool namaTidakDitemukan = names.Contains("Sher");
        bool namaDitemukan = names.Contains("Sherin");
        Console.WriteLine("Apakah 'Sher' ada dalam list? " + namaTidakDitemukan);
        Console.WriteLine("Apakah 'Sherin' ada dalam list? " + namaDitemukan);

    }

    // Dictionary
    static void Dictionary()
    {
        Console.WriteLine("CONTOH DICTIONARY");
        // Deklarasi dan inisialisasi Dictionary
        Dictionary<int, Employee> students = new Dictionary<int, Employee>();

        Employee employee1 = new Employee();
        employee1.FirstName = "John";
        employee1.LastName = "Jone";

        // Menambahkan pasangan kunci-nilai ke Dictionary
        students.Add(1, employee1);
        students.Add(2, employee1);
        students.Add(3, employee1);
        Console.WriteLine();
        Console.WriteLine("---ADD---");
        foreach (KeyValuePair<int, Employee> student in students)
        {
            Console.WriteLine("Student ID: " + student.Key + ", Name: " + student.Value.FirstName + student.Value.LastName);
        }


        // Menghapus pasangan kunci-nilai dari Dictionary
        students.Remove(1);
        Console.WriteLine();
        Console.WriteLine("---REMOVE---");
        foreach (var student in students) //bisa pakai var
        {
            Console.WriteLine("Student ID: " + student.Key + ", Name: " + student.Value);
        }

        // Menghitung 
        int jumlahDictionary = students.Count;
        Console.WriteLine();
        Console.WriteLine("--COUNT--");
        Console.WriteLine("Jumlah Dictionary :" + jumlahDictionary);

        // Memeriksa apakah kunci tertentu ada dalam Dictionary
        bool containsKey1 = students.ContainsKey(1);
        Console.WriteLine();
        Console.WriteLine("--CONTAINS---");
        Console.WriteLine("Apakah key '1' ada dalam Dictionary? " + containsKey1);

        // Memeriksa apakah nilai tertentu ada dalam Dictionary menggunakan metode ContainsValue()
       // bool containsValueGerard = students.ContainsValue("Gerard");
        //Console.WriteLine("Apakah value 'Gerard' ada dalam Dictionary? " + containsValueGerard);

        // Menghapus semua pasangan kunci-nilai dari Dictionary menggunakan metode Clear()
        Console.WriteLine();
        Console.WriteLine("--CLEAR--");
        students.Clear();

        // Menghitung jumlah pasangan kunci-nilai dalam Dictionary
        int jumlahDictionary2 = students.Count;
        Console.WriteLine("Jumlah Dictionary Setelah Di Clear():" + jumlahDictionary2);
    }

    // Queue
    static void Queue()
    {
        Console.WriteLine("CONTOH QUEUE");
        // Deklarasi dan inisialisasi Queue
        Queue<string> queue = new Queue<string>();

        // Menambahkan elemen ke dalam Queue menggunakan metode Enqueue()
        queue.Enqueue("Satu");
        queue.Enqueue("Dua");
        queue.Enqueue("Tiga");
        queue.Enqueue("Empat");
        Console.WriteLine("--Enqueue()--");
        foreach (string item in queue)
        {
            Console.WriteLine(item);
        }

        // Mengambil elemen yang berada di depan antrian menggunakan metode Dequeue()
        string item1 = queue.Dequeue();
        Console.WriteLine();
        Console.WriteLine("--Dequeue()--");
        Console.WriteLine("Elemen yang dihapus: " + item1);
        foreach (string item in queue)
        {
            Console.WriteLine(item);
        }

        // Mengembalikan elemen yang berada di depan Queue tanpa menghapusnya menggunakan metode Peek()
        string frontItem = queue.Peek();
        Console.WriteLine();
        Console.WriteLine("--Peek()--");
        Console.WriteLine("Elemen yang ada di depan : " + frontItem);
        foreach (string item in queue)
        {
            Console.WriteLine(item);
        }

        // Memeriksa apakah elemen tertentu ada dalam Queue.
        bool containsItem = queue.Contains("Dua");
        Console.WriteLine();
        Console.WriteLine("--Contains()--");
        Console.WriteLine("Apakah 'Dua' ada dalam antrian? " + containsItem);

        // Menghitung jumlah elemen dalam Queue menggunakan properti Count
        int jumlahElemen = queue.Count;
        Console.WriteLine();
        Console.WriteLine("--Count--");
        Console.WriteLine("Jumlah elemen dalam antrian: " + jumlahElemen);

        queue.Clear();
        int jumlahElemenClear = queue.Count;
        Console.WriteLine();
        Console.WriteLine("--Clear()--");
        Console.WriteLine("Jumlah elemen dalam antrian setelah dilakukan Clear: " + jumlahElemenClear);

    }
    // Stack
    static void Stack()
    {
        Console.WriteLine("CONTOH STACK");
        // Deklarasi dan inisialisasi Stack
        Stack<string> stack = new Stack<string>();

        // Menambahkan elemen ke Stack menggunakan metode Push()
        stack.Push("Elemen Ke-1");
        stack.Push("Elemen Ke-2");
        stack.Push("Elemen Ke-3");
        Console.WriteLine("--Push()--");
        foreach (string item in stack)
        {
            Console.WriteLine(item);
        }

        // Menghapus dan mengembalikan elemen teratas dari Stack menggunakan metode Pop()
        string item1 = stack.Pop();
        Console.WriteLine();
        Console.WriteLine("--Pop()--");
        Console.WriteLine("Elemen yang dihapus: " + item1);
        foreach (string item in stack)
        {
            Console.WriteLine(item);
        }

        // Mengembalikan elemen teratas dari Stack tanpa menghapusnya menggunakan metode Peek()
        string topItem = stack.Peek();
        Console.WriteLine();
        Console.WriteLine("--Peek()--");
        Console.WriteLine("Elemen teratas Stack: " + topItem);
        foreach (string item in stack)
        {
            Console.WriteLine(item);
        }

        // Menghitung jumlah elemen dalam Stack menggunakan properti Count
        int jumlahElemen = stack.Count;
        Console.WriteLine();
        Console.WriteLine("--Count--");
        Console.WriteLine("Jumlah elemen dalam Stack: " + jumlahElemen);
    }

    //SortedList
    static void SortedList()
    {
        Console.WriteLine("CONTOH SORTEDLLIST");
        // Deklarasi dan inisialisasi SortedList
        SortedList<int, string> sortedList = new SortedList<int, string>();

        // Menambahkan pasangan kunci-nilai ke dalam SortedList menggunakan metode Add()
        Console.WriteLine("Menambah Add()");
        sortedList.Add(3, "C");
        sortedList.Add(1, "A");
        sortedList.Add(4, "D");
        sortedList.Add(2, "B");
        foreach (KeyValuePair<int, string> item in sortedList)
        {
            Console.WriteLine("Key: " + item.Key + ", Value: " + item.Value);
        }

        // Menghapus pasangan kunci-nilai dari SortedList menggunakan metode Remove()
        sortedList.Remove(2);
        Console.WriteLine();
        Console.WriteLine("Menghapus Remove()");
        foreach (KeyValuePair<int, string> item in sortedList)
        {
            Console.WriteLine("Key: " + item.Key + ", Value: " + item.Value);
        }

        // Mendapatkan indeks dari nilai tertentu dalam SortedList menggunakan metode IndexOfValue()
        int indexKey1 = sortedList.IndexOfValue("A");
        Console.WriteLine();
        Console.WriteLine("Mencari Index dengan IndexOfValue()");
        Console.WriteLine("Indeks dari nilai 'A': " + indexKey1);

        // Memeriksa apakah nilai tertentu ada dalam SortedList menggunakan metode ContainsValue()
        bool containsValue = sortedList.ContainsValue("Z");
        Console.WriteLine();
        Console.WriteLine("Mencari Nilai dengan ContainsValue()");
        Console.WriteLine("Apakah nilai 'Z' ada dalam SortedList? " + containsValue);

        // Memeriksa apakah kunci tertentu ada dalam SortedList menggunakan metode ContainsKey()
        bool containsKey = sortedList.ContainsKey(3);
        Console.WriteLine();
        Console.WriteLine("Mencari Kunci dengan containsKey()");
        Console.WriteLine("Apakah kunci '3' ada dalam SortedList? " + containsKey);

    }



    public static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Menu();
            Console.Write("Pilih Menu : ");
            string pilih = Console.ReadLine();
            
            switch (pilih)
            {
                case "1":
                    Console.WriteLine("");
                    List();
                    break;
                case "2":
                    Console.WriteLine("");
                    Dictionary();
                    break;
                 case"3":
                    Console.WriteLine("");
                    Queue();
                    break;
                 case "4":
                 Console.WriteLine("");
                    Stack();
                    break;
                case "5":
                    Console.WriteLine("");
                    SortedList();
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Pilihan tidak ada");
                    break;
            }
            Console.WriteLine();
        }        
    }

}

class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}