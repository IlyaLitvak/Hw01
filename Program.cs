//String[] A= {"hello","2","world",";-)"};
//String[] A= {"1234","1567","-2","computer science"};
//String[] A= {"Russia","Denmark","Kazan"};
List<String> A=new List<String>();
Console.WriteLine("Enter Strings and press enter. At the end write EXIT word and press enter");
while(true){
    String input=Console.ReadLine();
    if(input.Equals("EXIT")){
        break;
    }
    A.Add(input);
}
List<String> B=new List<String>();
for(int i=0;i<A.Count;i++){
//for(int i=0;i<A.Length;i++){
    if (A[i].Length <=3){
        B.Add(A[i]);
    }
}

for (int i = 0; i<B.Count; i++){
    Console.WriteLine(B[i]);
}

