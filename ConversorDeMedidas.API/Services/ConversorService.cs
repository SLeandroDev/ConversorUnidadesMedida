namespace ConversorDeMedidas.API.Services
{
    public class ConversorService
    {
        public double Converter(double valor, string unidadeOrigem, string unidadeDestino)
        {
            // Lógica de conversão ()
            
            

            if (unidadeOrigem == "metros" && unidadeDestino == "centimetros")
            {
                return valor * 100;
            }
            else if (unidadeOrigem == "centimetros" && unidadeDestino == "metros")
            {
                return valor / 100;
            }
            else if (unidadeOrigem == "polegadas" && unidadeDestino == "centimetros")
            {
                return valor * 2.54;
            }
            else if (unidadeOrigem == "centimetros" && unidadeDestino == "polegadas")
            {
                return valor / 2.54;
            }
            else if (unidadeOrigem == "polegadas" && unidadeDestino == "metros")
            {
                return valor * 0.0254;
            }
            else if (unidadeOrigem == "metros" && unidadeDestino == "polegadas")
            {
                return valor * 39.37;
            }

            return valor; // Retorna o valor original se não houver conversão definida
        }
    }
}
