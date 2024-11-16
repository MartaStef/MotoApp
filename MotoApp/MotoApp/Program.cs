using MotoApp;

var stack = new BasicStack<double>();

stack.Push(4.6);
stack.Push(43);
stack.Push(333.5);

double sum = 0.0;

var stackString = new BasicStack<string>();

stackString.Push("Company1");
stackString.Push("Company2");
stackString.Push("Company3");

while (stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"item:{item}");
    sum += item;
}

Console.WriteLine($"sum:{sum}");

//napisac test jednostkowy