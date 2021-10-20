
import dotnet;

@_cdecl("swift_main")
public func swift_main() -> Swift.Int32
{
    do 
    {
        try System.Console.WriteLine(value: "Hello World");
        try System.Console.WriteLine(value: "FirstName LasltName");
        try System.Console.WriteLine(value: "Oleksandra Brechko");

        return 0;
    } 
    catch let e as System.Exception 
    {
        try! System.Console.WriteLine(value: e.ToString());
        return -1;
    }
    catch 
    {
        print("Unhandled error of some kind");
        return -1;
    } 
}

