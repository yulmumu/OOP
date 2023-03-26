# OOP
C#으로 STACK 구현(배열 & 링크드 리스트) 및 테스트

# code

    using System;
using System.Collections.Generic;  //제네릭 클래스는 특정 데이터 형식과 관련이 없는 작업을 캡슐화합니다.
                                     컬렉션 내부에 저장되는 데이터 타입을 컴파일 시점에서 결정할 수 있도록 해줍니다.

public class Example
{
    public static void Main(string[] args)
    {
        LinkedList<String> countries = new LinkedList<String>();  //링크드리스트 클래스를 이용하여 링크드리스트 생성
  
        countries.AddLast("India");  //링크드리스트에 AddLast()메소드를 사용하여 요소 입력
        countries.AddLast("Mexico");
        countries.AddLast("Japan");
        countries.AddLast("Nepal");
        countries.AddLast("Korea");

        //"Nepal" 전,후로 새로운 요소 삽입
        LinkedListNode<String> node = countries.Find("Nepal");
        countries.AddBefore(node, "Australia");
        countries.AddAfter(node, "Canada"); 
 
        //각 루프에 대해 연결된 목록 요소 반복
        foreach (var country in countries)
        {
            Console.WriteLine(country); //India -> Mexico -> Japan -> Australia -> Nepal -> Canada -> Korea
        }
        
         //Remove(LinkedListNode)메소드 사용
        Console.WriteLine("----------");
        countries.Remove(countries.First);
        foreach (var country in countries)
        {
            Console.WriteLine(country); //
        }
        
        //Remove(T)메소드 사용
        Console.WriteLine("----------");
        countries.Remove("Australia");
        foreach (var country in countries)
        {
            Console.WriteLine(country);
        }
    }
}
