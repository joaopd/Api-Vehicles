namespace Domain.ValueObject
{
    /// <summary>
    /// Ref https://eximia.co/validacao-de-cpf/
    /// </summary>
    public readonly struct Cpf
    {
        private readonly string _value;

        public readonly bool EhValido;

#pragma warning disable S3776

        public Cpf(string value)
        {
            _value = value;

            if (value == null)
            {
                EhValido = false;
                return;
            }

            var posicao = 0;
            var totalDigito1 = 0;
            var totalDigito2 = 0;
            var dv1 = 0;
            var dv2 = 0;

            var digitosIdenticos = true;
            var ultimoDigito = -1;

            foreach (var c in value)
            {
                if (!char.IsDigit(c)) continue;

                var digito = c - '0';
                if (posicao != 0 && ultimoDigito != digito)
                {
                    digitosIdenticos = false;
                }

                ultimoDigito = digito;

                switch (posicao)
                {
                    case < 9:
                        totalDigito1 += digito * (10 - posicao);
                        totalDigito2 += digito * (11 - posicao);
                        break;

                    case 9:
                        dv1 = digito;
                        break;

                    case 10:
                        dv2 = digito;
                        break;
                }

                posicao++;
            }

            if (posicao > 11)
            {
                EhValido = false;
                return;
            }

            if (digitosIdenticos)
            {
                EhValido = false;
                return;
            }

            var digito1 = totalDigito1 % 11;
            digito1 = digito1 < 2
                ? 0
                : 11 - digito1;

            if (dv1 != digito1)
            {
                EhValido = false;
                return;
            }

            totalDigito2 += digito1 * 2;
            var digito2 = totalDigito2 % 11;
            digito2 = digito2 < 2
                ? 0
                : 11 - digito2;

            EhValido = dv2 == digito2;
        }

#pragma warning restore S3776

        public static implicit operator Cpf(string value)
            => new(value);

        public override string ToString() => _value;
    }
}
