//String[] A= {"hello","2","world",";-)"};
//String[] A= {"1234","1567","-2","computer science"};
String[] A= {"Russia","Denmark","Kazan"};
List<String> B=new List<String>();
for(int i=0;i<A.Length;i++){
    if (A[i].Length <=3){
        B.Add(A[i]);
    }
}

for (int i = 0; i<B.Count; i++){
    Console.WriteLine(B[i]);
}

