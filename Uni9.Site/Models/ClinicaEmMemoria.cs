namespace ClinicaVida.Web.Models;

public static class ClinicaEmMemoria
{
    public static List<Especialidade> Especialidades { get; } = new()
    {
        new Especialidade { Id = 1, Nome = "Cardiologia", Descricao = "Coração e vasos" },
        new Especialidade { Id = 2, Nome = "Pediatria", Descricao = "Saúde de crianças e adolescentes" },
        new Especialidade { Id = 3, Nome = "Dermatologia", Descricao = "Pele, cabelo e unhas" },
        new Especialidade { Id = 4, Nome = "Ortopedia", Descricao = "Ossos, músculos e articulações" }
    };

    public static List<Medico> Medicos { get; } = new()
    {
        new Medico { Id = 1, Nome = "Dra. Marta Lisboa", Crm = "55307", EspecialidadeId = 1 },
        new Medico { Id = 2, Nome = "Dr. Paulo Andrade", Crm = "61842", EspecialidadeId = 1 },
        new Medico { Id = 3, Nome = "Dra. Helena Duarte", Crm = "48215", EspecialidadeId = 2 },
        new Medico { Id = 4, Nome = "Dr. Rafael Moura", Crm = "72960", EspecialidadeId = 2 },
        new Medico { Id = 5, Nome = "Dra. Camila Ferraz", Crm = "39574", EspecialidadeId = 3 },
        new Medico { Id = 6, Nome = "Dr. Bruno Teixeira", Crm = "80431", EspecialidadeId = 4 }
    };
}