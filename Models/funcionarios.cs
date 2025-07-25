using System;
using System.Runtime.CompilerServices;

namespace FolhaFacilSimulado.Models;

public class FUNCIONARIOS
{
    public int ID { get; set; }
    public string NOME { get; set; }
    public decimal SALARIO { get; set; }
    public int HORAEXTRA { get; set; }
    public int DEPENDENTES { get; set; }
    public DateTime DTADMISS { get; set; }
    public string M_ESOCIAL { get; set; }
    public string CTPS { get; set; }
    public string CPF { get; set; }
    public string RG { get; set; }

    public FUNCIONARIOS() { }

    public FUNCIONARIOS(string nome, decimal salarioBase, int horasExtras, int dependentes, DateTime dataAdmissao,
                        string mesocial, string ctps, string cpf, string rg)
    {
        NOME = nome;
        SALARIO = salarioBase;
        HORAEXTRA = horasExtras;
        DEPENDENTES = dependentes;
        DTADMISS = dataAdmissao;
        M_ESOCIAL = mesocial;
        CTPS = ctps;
        CPF = cpf;
        RG = rg;
    }

    public override string ToString()
    {
        return $"{NOME} - R$ {SALARIO:F2} - {HORAEXTRA}h extra - {DEPENDENTES} dependente(s)";
    }
}