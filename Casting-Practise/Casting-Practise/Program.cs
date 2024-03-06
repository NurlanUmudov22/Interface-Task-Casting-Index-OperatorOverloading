
//boxing-unboxing



//int a = 5;

//object b = a;

//int a = 6;

//object b = a;

//int c = (int)b;

//Console.WriteLine(c);



//implicit

//byte num = 50;

//int num2 = num;



////eksplicit

//int a = 10;

//byte b =(byte)a;

//Console.WriteLine(b);





using Casting_Practise;

Fish fish = new Fish();

Animal animal1 = fish;



//Animal animal2 = new Animal();
//Fish fish1 = (Fish)animal2;


Animal animal3 = new Dog();

Animal animal4 = new Fish();

Animal animal = new();

//Fish fish1 = (Fish)animal;



Dog dog = new Dog();



//object[] datas = { 1, 2, true, "salam" };


//Animal[] animals = { animal1, animal3, animal4, dog };





object[] animals = { animal1, animal3, animal4, dog, "name" };


//foreach (var item in animals)
//{
//    Console.WriteLine(item is Animal);
//}





//foreach (var item in animals)
//{

//    if (item is Animal)
//    {
//        Console.WriteLine("yes");
//    }
//}






//foreach (var item in animals)
//{
//    if(item is Animal a)
//    {
//        a.Name = "Toplan";

//        Console.WriteLine(a.Name);
//    }
//}






//foreach (var item in animals)
//{
//    Animal data = item as Animal;

//    if (data is not null)
//    {
//        data.Name = "Akula";
//        Console.WriteLine(data.Name);
//    }
//}








DataList dataList = new DataList();

dataList[0] = "salam";
dataList[1] = "sagol";

//Console.WriteLine(dataList[0]);
//Console.WriteLine(dataList[1]);









Employee employee1 = new Employee();
employee1.Id = 1;
employee1.Age = 25;

Employee employee2 = new Employee();
employee2.Id = 2;
employee2.Age = 30;

//Console.WriteLine(employee1 > employee2);








