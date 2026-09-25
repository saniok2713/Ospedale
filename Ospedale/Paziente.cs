using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ospedale {

	class Paziente {
		private string _cognome;
		private string _nome;
		private string _CF;
		private int _matricola_medico_ass;
		public Paziente(string cognome, string nome, string cf) {
			this._cognome = cognome;
			this._nome = nome;
			this._CF = cf;
		}

		public string Cognome {
			get { return _cognome; }
			set { _cognome = value; }
		}

		public string Nome {
			get { return _nome; }
			set { _nome = value; }
		}

		public string CF {
			get { return _CF; }
			set { _CF = value; }
		}

		public int Medico_Assegnato {
			get { return _matricola_medico_ass; }
			set { _matricola_medico_ass = value; }
		}
	}
}
