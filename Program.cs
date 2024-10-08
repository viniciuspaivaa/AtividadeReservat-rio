class Program
{
    static void Main(string[] args)
    {
        bool bomba = false;
        bool torneira = false;
        bool erro = false;
        int reserva = 0;
        int minReserva = 20;
        int maxReserva = 102;
        int caixa = 0;
        int maxCaixa = 30;
        string resolucao;

  
        while(!erro)
        {   
            //Reservatório vazio
            if(reserva <= minReserva && caixa < maxCaixa)
            {
                bomba = false;
                torneira = true;
                reserva += 6;
                resolucao = "nenhuma";
            }
            //Reservatório ideal, caixa vazia
            else if(reserva >= minReserva && reserva < maxReserva && caixa < maxCaixa)
            {
                bomba = true;
                torneira = true;
                reserva += 4;
                caixa += 2;
                resolucao = "A";
            }
            //Reservatório ideal, caixa cheia
            else if(reserva < maxReserva && caixa == maxCaixa)
            {
                bomba = false;
                torneira = true;
                reserva += 6;
                resolucao = "A e C";
            }
            //Reservatório cheio, caixa vazia
            else if(reserva >= maxReserva && caixa < maxCaixa)
            {
                bomba = true;
                torneira = false;
                reserva -= 2;
                caixa += 2;
                resolucao = "A";
            }
            //Reservatório cheio, caixa cheia
            else if(reserva >= maxCaixa && caixa >= maxCaixa)
            {
                bomba = false;
                torneira = false;
                resolucao = "A, B e C";
            }
            else
            {
                erro = true;
                resolucao = "erro";
            }


            string onOffBomb = bomba ? "ligada" : "desligada";
            string onOffTorn = torneira ? "ligada" : "desligada";
            
            Console.Clear();
            if(erro)
            {
                Console.Write("Erro no sitema, chame um técnico!");
            }
            else
            {
                Console.Write($"Caixa d'água: {caixa}/{maxCaixa}\nReservatório: {reserva}/{maxReserva}\n\nBomba: {onOffBomb}\nTorneira: {onOffTorn}\nBóias ativadas: {resolucao}");
            }
            Thread.Sleep(1000);
        }
    }
}
