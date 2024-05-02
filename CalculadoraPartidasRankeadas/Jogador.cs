public class Jogador
{
    public short saldoVitorias {get;}

    public Jogador(short vitorias, short derrotas)
    {
        this.saldoVitorias = (short)(vitorias - derrotas);
    }

    public string ObterClasseJogador()
    {
        if (saldoVitorias < 10)
            return Constantes.FERRO;
        else if (saldoVitorias <= 20)
            return Constantes.BRONZE;
        else if (saldoVitorias <= 50)
            return Constantes.PRATA;
        else if (saldoVitorias <= 80)
            return Constantes.OURO;
        else if (saldoVitorias <= 90)
            return Constantes.DIAMANTE;
        else if (saldoVitorias <= 100)
            return Constantes.LENDARIO;
        else
            return Constantes.IMORTAL;
    }
}