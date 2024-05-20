//сума = депозирана сума + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)


double deposit = double.Parse(Console.ReadLine());
int term = int.Parse(Console.ReadLine());
double rate = double.Parse(Console.ReadLine()) / 100;
double sum = deposit + term * (deposit * rate / 12);
Console.WriteLine(sum);