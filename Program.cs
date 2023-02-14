double salarioBruto, impostoDevido;
Console.WriteLine("Bem vindo! Informe o salário bruto:");
salarioBruto = double.Parse(Console.ReadLine());
if (salarioBruto <= 900) {
    Console.WriteLine($"Com salário de R$ {salarioBruto}, você está isento da cobrança de imposto.");
}
else if(salarioBruto > 900 && salarioBruto <= 1500) {
 impostoDevido = salarioBruto * 0.05;
 Console.WriteLine($"Você foi taxado em 5% e pagará R$ {impostoDevido} em impostos.");
}
else if(salarioBruto > 1500 && salarioBruto <= 2500) {
    impostoDevido = salarioBruto * 0.1;
    Console.WriteLine($"Você foi taxado em 10% e pagará R$ {impostoDevido} em impostos.");
}
else {
    impostoDevido = salarioBruto * 0.2;
    Console.WriteLine($"Você foi taxado em 20% e pagará R$ {impostoDevido} em impostos.");
}
