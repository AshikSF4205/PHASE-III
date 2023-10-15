using System;
using System.Xml;
namespace SealedClasses;

class Program
{
    public static void Main(string[] args)
    {
        string letter  = "3[a2[b]]";
        printS(letter);
        string letter2  = "2[a]2[b]";
    }
    public static void printS(string word){

        Stack<Char> chars  = new Stack<char>();
        foreach(char letter in word){
            chars.Push(letter);
        }

        string ans = "";
        string times = "";
        while(chars.ToArray().Length != 0 ){
            
            if(chars.Peek() == ']'){
                    chars.Pop();
            }
            else if(chars.Peek()=='[')
            {
                    chars.Pop();

            }else{
                if((int) chars.Peek() >=45 && (int) chars.Peek() <=54 ){                    
                    // System.Console.WriteLine(chars.Pop());
                    for(int i = 0;i<(int) chars.Peek();i++ ){
                        times+=ans;
                    }
                }else{
                    // System.Console.WriteLine();
                    ans += chars.Pop();
                }
            }
        
        }

        System.Console.WriteLine(times);

    }
}