using System.Globalization;
using System.Text.RegularExpressions;
using Cadastro_Pessoa.Classes;

PessoaFisica novaPessoaFisica = new PessoaFisica();

novaPessoaFisica.Nome = "Lorenzo";
novaPessoaFisica.Cpf = "12345678910";
novaPessoaFisica.DataNascimento = new DateTime(2017,10,19);
novaPessoaFisica.Rendimento = 50000.50f;

PessoaFisica MetodosPf = new PessoaFisica();

Console.WriteLine(@$"
Nome: {novaPessoaFisica.Nome}
CPF: {novaPessoaFisica.Cpf}
Data de Nascimento: {novaPessoaFisica.DataNascimento}
Rendimento: R${novaPessoaFisica.Rendimento}
Imposto a Pagar: {MetodosPf.PagarImposto(novaPessoaFisica.Rendimento).ToString("C", new CultureInfo("pt-BR"))}
Maior de idade - dateTime: {MetodosPf.ValidarDataNascimento(novaPessoaFisica.DataNascimento)}
Maior de idade - dateTime: {(MetodosPf.ValidarDataNascimento(novaPessoaFisica.DataNascimento) ? "Sim" : "Não")}
Maior de idade - string: {MetodosPf.ValidarDataNascimento("19/10/2017")}
");

PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

Endereco novoEndereco = new Endereco();

novoEndereco.Logradouro = "Av Interlagos";
novoEndereco.Numero = 1609;
novoEndereco.Complemento = "Interclube";
novoEndereco.Comercial = true;
novoEndereco.Cep = "04661100";

novaPessoaJuridica.Nome = "Palmeiras";
novaPessoaJuridica.RazaoSocial = "S.E.Palmeiras";
novaPessoaJuridica.Cnpj = "22.658.312/0001-77";
novaPessoaJuridica.Rendimento = 250000.99f;
novaPessoaJuridica.Endereco = novoEndereco;

PessoaJuridica metodosPJ = new PessoaJuridica();

Console.WriteLine(@$"
Nome Fantasia: {novaPessoaJuridica.Nome}
Razão Social: {novaPessoaJuridica.RazaoSocial}
CNPJ: {novaPessoaJuridica.Cnpj}
CNPJ valido: {(metodosPJ.ValidarCnpj(novaPessoaJuridica.Cnpj)? "Cnpj no formato valido" : "Cnpj fora do padrão")}
Rendimento Mensal: R${novaPessoaJuridica.Rendimento}
Imposto a pagar :  {metodosPJ.PagarImposto(novaPessoaJuridica.Rendimento).ToString("C", new CultureInfo("pt-BR"))}

Endereco : {novaPessoaJuridica.Endereco.Logradouro} 
Numero : {novaPessoaJuridica.Endereco.Numero}
Complemento : {novaPessoaJuridica.Endereco.Complemento}
Endereço Comercial : {novaPessoaJuridica.Endereco.Comercial}
CEP : {novaPessoaJuridica.Endereco.Cep}
");

//ToString transforma o numero (float) para texto (string)


// exemplo de expressao regular para validar um formato de data
// string data = "26/09/2022";
// bool valido = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");
// Console.WriteLine(valido ? "dentro do padrao" : "fora do padrao, insira nova data");

// exemplo de substring com dois argumentos
// start~Index : da onde vai partir
// Lenght : quantos objetos vamos obter
// string nome = "Pindamonhangaba";
// string substring = nome.Substring(3);
// Console.WriteLine(substring);
