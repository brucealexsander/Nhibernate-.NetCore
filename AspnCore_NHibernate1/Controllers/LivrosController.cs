using Microsoft.AspNetCore.Mvc;
using NHibernate;
using System;
using System.Linq;

namespace AspnCore_NHibernate1.Controllers
{
    public class LivrosController : Controller
    {
        private readonly ISession _session;
        public LivrosController(ISession session)
        {
            _session = session;
        }

        public IActionResult Index()
        {
            var filters = new { DataInicio = new DateTime(2019, 06, 01, 10, 00, 00), DataTermino = new DateTime(2019, 06, 01, 19, 00, 00) };

            var list = _session.QueryOver<Models.Livro>()
                .Where(r => (filters.DataInicio.TimeOfDay >= r.DataCadastro.TimeOfDay && filters.DataInicio.TimeOfDay <= r.DataCadastro.TimeOfDay)
                            || (filters.DataTermino.TimeOfDay >= r.DataCadastro.TimeOfDay && filters.DataTermino.TimeOfDay <= r.DataCadastro.TimeOfDay)
                            || (r.DataCadastro.TimeOfDay >= filters.DataInicio.TimeOfDay && r.DataCadastro.TimeOfDay <= filters.DataTermino.TimeOfDay)
                            || (r.DataCadastro.TimeOfDay >= filters.DataInicio.TimeOfDay && r.DataCadastro.TimeOfDay <= filters.DataTermino.TimeOfDay)).List();
            return View(list);
        }
    }
}