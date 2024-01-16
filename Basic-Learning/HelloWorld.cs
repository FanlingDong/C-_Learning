using System; // 引入System命名空间，才能使用Console

// 命名空间不能用数字开头
// 命名空间和项目名保持一致
// 别人使用代码的时候就要引入我们的这个命名空间
namespace _001_begin
{
    // 创建一个类，HelloWorld是类名，会和文件名保持一致
    public class HelloWorld
    {
        // 类包含了程序使用的数据和方发声明，类一般包含多个方法
        // 方法定义了类的行为
        
        static void Main(string[] args)
        {
            /*
             * 这是多行注释
             */
            // Console是一个类，WriteLine是一个方法
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
        }
    }
}

