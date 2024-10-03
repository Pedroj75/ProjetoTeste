using Microsoft.AspNetCore.Mvc;
using ClinicaPsicologica.Models;

namespace ClinicaPsicologica.Controllers
{
    public class PacienteController : Controller
    {
        private static List<Paciente> pacientes = new List<Paciente>(); // Simula o banco de dados

        // Exibe o formulário de cadastro
        public IActionResult Cadastrar()
        {
            ViewData["Title"] = "Cadastro de Paciente"; // Define o título da página
            return View();
        }

        // Salva o paciente após o formulário ser enviado
        [HttpPost]
        public IActionResult Cadastrar(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                pacientes.Add(paciente); // Adiciona o paciente à lista
                return RedirectToAction("MeusPacientes"); // Redireciona para a lista de pacientes
            }

            return View(paciente); // Retorna à view de cadastro em caso de erro
        }

        // Exibe a lista de pacientes cadastrados
        public IActionResult MeusPacientes()
        {
            ViewData["Title"] = "Meus Pacientes"; // Define o título da página
            return View(pacientes); // Passa a lista de pacientes para a view
        }
    }
}
