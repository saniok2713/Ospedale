using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ospedale {
	class Medico {
		public string _cognome;
		private string _nome;
		private int _matricola;
		private int _num_pazienti;
		public Medico(string cognome, string nome, int matricola) {
			this._cognome = cognome;
			this._nome = nome;
			this._matricola = matricola;
		}

		public string Cognome {
			get { return _cognome; }
			set { _cognome = value; }
		}

		public string Nome {
			get { return _nome; }
			set { _nome = value; }
		}

		public int Matricola {
			get { return _matricola; }
			set { _matricola = value; }
		}

		public int Num_pazienti {
			get { return _num_pazienti; }
			set { _num_pazienti = value; }
		}
	}
}
