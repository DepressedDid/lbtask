using System.Collections;
using System.Collections.Generic;
using System.Globalization;
List<string> PeopleList = new List<string>();
string[] PeopleArr = new string[] { "Kate", "Jumaysunba", "Adam","Biba","Boba" };

ListFillSort(PeopleList, PeopleArr);
Console.WriteLine();
RemoveListElements(PeopleList);
Console.WriteLine();

void ListFillSort(List<string> yourList, string[] Arr)
{
    yourList.AddRange(Arr);
    yourList.Sort();
    Console.WriteLine("Sorted group list:");
    foreach (string people in yourList)
    {
        Console.WriteLine(people);
    }
}

void RemoveListElements(List<string> yourList)
{
    Console.WriteLine("New List;");
    yourList.RemoveRange(0,3);
    foreach(string people in yourList)
    {
        Console.WriteLine(people);
    }
}





List<string> groupList = new List<string>();
Dictionary<int,string> Group = new Dictionary<int, string>()
{
    [45] = "Oleg Lyashko",
    [36] = "Petro Poroshenko",
    [27] = "Anatoly Shariy",
    [87] = "Seryoga Pirat",
    [67] = "Viktor Dudka"
};

Examresults_CreatingList(Group, groupList);

void Examresults_CreatingList(Dictionary<int, string> Group, List<string> groupList)
{
    int score;
    Console.WriteLine("Exam result in group:");
    foreach (var result_student in Group)
    {
        if (result_student.Key >= 60)
        {
            Console.WriteLine(result_student.Value + " " + result_student.Key + " exam passed");
        }
        else
        {
            Console.WriteLine(result_student.Value + " " + result_student.Key + " exam not passed");
            score = result_student.Key;
            Group.Remove(result_student.Key);
        }
    }
    Console.WriteLine();
    Console.WriteLine("New group list:");
    foreach (var students in Group)
    {
        groupList.Insert(0,students.Value);
        Console.WriteLine(groupList[0]);
    }
}
Console.WriteLine();





Queue<string> Libraryqueue = new Queue<string>();
AddToLibraryQueue(Libraryqueue, PeopleArr);
Console.WriteLine();
LibDequeuing(Libraryqueue);

void AddToLibraryQueue(Queue<string> queue, string[] Array)
{
    for(int i = 0; i<Array.Length;i++)
    {
        queue.Enqueue(Array[i]);
        Console.WriteLine(Array[i]+ " registered in the queue");
    }
    Console.WriteLine("First in queue: "+ queue.Peek());
}


void LibDequeuing(Queue<string> queue)
{
    for (int i = 0; i < queue.Count;)
    {       
        Console.WriteLine(queue.Dequeue() + " leaved queue");
    }
}
Console.WriteLine();





Stack<string> magazine = new Stack<string>();
string[] cartridgearray = new string[] { "cartridge1", "cartridge2", "cartridge3", "cartridge4", "cartridge5", "cartridge6", "cartridge7" };

Reload(magazine, cartridgearray);
Console.WriteLine();
Shoting(magazine);

void Reload(Stack<string> yourmagazine, string[] cartridge)
{
    for(int i = 0; i < cartridge.Length; i++)
    {
        yourmagazine.Push(cartridge[i]);
        Console.WriteLine(yourmagazine.Peek()+ " in magazane");
    }
    Console.WriteLine("Magazine is full");
}
void Shoting(Stack<string> yourmagazine)
{
    for(int i=0;i<yourmagazine.Count;)
    {
        Console.WriteLine(yourmagazine.Pop()+ " hit the target");
    }
    Console.WriteLine("Magazine is empty");
}