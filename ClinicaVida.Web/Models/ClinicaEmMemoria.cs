namespace ClinicaVida.Web.Models;

public static class ClinicaEmMemoria
{
    public static List<Especialidade> Especialidades { get; } = new()
    {
        new Especialidade { Id = 1, Nome = "Cardiologia",  Descricao = "Coração e vasos" },
        new Especialidade { Id = 2, Nome = "Pediatria",    Descricao = "Saúde de crianças e adolescentes" },
        new Especialidade { Id = 3, Nome = "Dermatologia", Descricao = "Pele, cabelos e unhas" },
        new Especialidade { Id = 4, Nome = "Ortopedia",    Descricao = "Ossos, músculos e articulações" },
    };

    public static List<Medico> Medicos { get; } = new()
    {
        new Medico { Id = 1, Nome = "Dra. Marta Lisboa",  Crm = "55307", EspecialidadeId = 1 },
        new Medico { Id = 2, Nome = "Dr. Caio Nunes",     Crm = "41880", EspecialidadeId = 2 },
        new Medico { Id = 3, Nome = "Dra. Helena Prado",  Crm = "62114", EspecialidadeId = 1 },
        new Medico { Id = 4, Nome = "Dr. Ivo Reis",       Crm = "48273", EspecialidadeId = 4 },
        new Medico { Id = 5, Nome = "Dra. Sofia Brandão", Crm = "57391", EspecialidadeId = 2 },
        new Medico { Id = 6, Nome = "Dr. Otávio Lemos",   Crm = "60845", EspecialidadeId = 3 },
    };
}
