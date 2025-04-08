using System;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TriviaPro
{
    public static class PreguntaFactory
    {
        private static readonly Random random = new Random();

        public static Pregunta CrearPregunta(string categoria, string nivel)
        {
            var preguntas = new List<Pregunta>();

           if(categoria == "Ciencia")
            {
                if(nivel == "Facil")
                {
                    preguntas.Add(new PreguntaFacil(
                        "¿Cuál es el planeta más cercano al Sol?",
                        new List<string> { "Mercurio", "Venus", "Marte", "Júpiter" }, 0, "Ciencia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Cuál es el estado del agua a temperatura ambiente?",
                        new List<string> { "Gaseoso", "Solido", "Liquido", "Plasma" }, 2, "Ciencia"));

                    preguntas.Add(new PreguntaFacil(
                         "¿Qué órgano del cuerpo humano bombea la sangre?",
                         new List<string> { "Estomago", "Corazon", "Pulmon", "Riñon" }, 1, "Ciencia"));

                    preguntas.Add(new PreguntaFacil(
                    "¿Qué gas respiramos los humanos?",
                        new List<string> { "Hidrogeno", "Oxigeno", "Dióxido de carbono", "Helio" },
                        1, "Ciencia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Cuál es el hueso más largo del cuerpo humano?",
                        new List<string> { "Fémur", "Cráneo", "Húmero", "Tibia" },
                        0, "Ciencia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Qué planeta es conocido como el planeta rojo?",
                        new List<string> { "Neptuno", "Júpiter", "Saturno", "Marte" },
                        3, "Ciencia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Cuántos sentidos tiene el ser humano?",
                        new List<string> { "Siete", "Cuatro", "Seis", "Cinco" },
                        3, "Ciencia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Qué tipo de animal es una ballena?",
                        new List<string> { "Pez", "Mamifero", "Reptil", "Anfibio" },
                        1, "Ciencia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Cómo se llama el proceso por el cual las plantas fabrican su alimento?",
                        new List<string> { "Fotosíntesis", "Digestión", "Respiración", "Germinación" },
                        0, "Ciencia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Qué astro ilumina la Tierra durante el día?",
                        new List<string> { "Venus", "La Luna", "El Sol", "Saturno" },
                        2, "Ciencia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Qué parte de la planta se encarga de absorber agua?",
                        new List<string> { "Hoja", "Raiz", "Tallo", "Flor" },
                        1, "Ciencia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Cuál es el órgano principal del sistema respiratorio?",
                        new List<string> { "Esofago", "Hígado", "Corazón", "Pulmon" },
                        3, "Ciencia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Cómo se llama el satélite natural de la Tierra?",
                        new List<string> { "Sol", "Marte", "La Luna", "Plutón" },
                        2, "Ciencia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Qué fuerza mantiene los planetas en órbita?",
                        new List<string> { "Inercia", "Gravedad", "Fricción", "Empuje" },
                        1, "Ciencia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Cuántas patas tiene una araña?",
                        new List<string> { "Ocho", "Seis", "Diez", "Cuatro" },
                        0, "Ciencia"));
                }
                else if (nivel == "Medio")
                {
                    preguntas.Add(new PreguntaMedia(
                        "¿Cuántas patas tiene una araña?",
                        new List<string> { "Protón", "Neutrón", "Electrón", "Quark" },
                        2, "Ciencia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Cuál es la unidad de medida de la fuerza en el Sistema Internacional?",
                        new List<string> { "Joule", "Pascal", "Newton", "Watt" },
                        2, "Ciencia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué estructura celular contiene el material genético?",
                        new List<string> { "Mitocondria", "Núcleo", "Ribosoma", "Lisosoma" },
                        1, "Ciencia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué tipo de energía se almacena en los alimentos?",
                        new List<string> { "Eléctrica", "Cinética", "Química", "Luminosa" },
                        2, "Ciencia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué nombre recibe el cambio de estado de gas a líquido?",
                        new List<string> { "Sublimación", "Fusión", "Condensación", "Evaporación" },
                        2, "Ciencia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Cuál es el símbolo químico del oro?",
                        new List<string> { "Ag", "Au", "Pb", "Fe" },
                        1, "Ciencia"));

                    preguntas.Add(new PreguntaMedia(
                       "¿Cuál es la velocidad de la luz en el vacío (aproximadamente)?",
                       new List<string> { "300,000 km/s", "150,000 km/s", "1,080 km/h", "3,000 km/s" },
                       0, "Ciencia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué planeta tiene un sistema de anillos muy visible?",
                        new List<string> { "Urano", "Neptuno", "Saturno", "Marte" },
                        2, "Ciencia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué nombre recibe el órgano que filtra la sangre en el cuerpo humano?",
                        new List<string> { "Corazón", "Riñón", "Pulmón", "Hígado" },
                        1, "Ciencia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué científico propuso la teoría de la relatividad?",
                        new List<string> { "Isaac Newton", "Albert Einstein", "Galileo Galilei", "Nikola Tesla" },
                        1, "Ciencia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué vitamina se obtiene al exponerse al sol?",
                        new List<string> { "Vitamina A", "Vitamina B12", "Vitamina C", "Vitamina D" },
                        3, "Ciencia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Cuál es el nombre del proceso de división celular en células somáticas?",
                        new List<string> { "Meiosis", "Mitosis", "Osmosis", "Síntesis" },
                        1, "Ciencia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué tipo de sangre es el donante universal?",
                        new List<string> { "A+", "AB+", "O−", "B−" },
                        2, "Ciencia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué planeta tiene la mayor cantidad de lunas?",
                        new List<string> { "Júpiter", "Marte", "Tierra", "Saturno" },
                        0, "Ciencia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué componente del aire es el más abundante?",
                        new List<string> { "Oxígeno", "Nitrógeno", "Dióxido de carbono", "Hidrógeno" },
                        1, "Ciencia"));
                }
                else if (nivel == "Dificil")
                {
                    preguntas.Add(new PreguntaDificil(
            "¿Qué científico descubrió la penicilina?",
            new List<string> { "Alexander Fleming", "Louis Pasteur", "Marie Curie", "Gregor Mendel" },
            0, "Ciencia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué es un número atómico en la tabla periódica?",
                        new List<string> { "El número de electrones", "La cantidad de neutrones", "El número de protones", "La masa atómica" },
                        2, "Ciencia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué tipo de enlace une a los aminoácidos en una proteína?",
                        new List<string> { "Enlace iónico", "Enlace peptídico", "Enlace covalente no polar", "Enlace metálico" },
                        1, "Ciencia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué ley describe la relación entre presión y volumen en un gas?",
                        new List<string> { "Ley de Newton", "Ley de Ohm", "Ley de Boyle", "Ley de Faraday" },
                        2, "Ciencia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué nombre recibe el fenómeno de emisión de luz por una sustancia sin generación de calor?",
                        new List<string> { "Incandescencia", "Fluorescencia", "Refracción", "Difracción" },
                        1, "Ciencia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Cuál es el pH neutro en la escala?",
                        new List<string> { "5", "6", "7", "8" },
                        2, "Ciencia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué científico propuso el principio de incertidumbre?",
                        new List<string> { "Werner Heisenberg", "Niels Bohr", "Max Planck", "Erwin Schrödinger" },
                        0, "Ciencia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué partícula subatómica tiene la mayor masa?",
                        new List<string> { "Electrón", "Protón", "Neutrón", "Positrón" },
                        1, "Ciencia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué tipo de célula no tiene núcleo definido?",
                        new List<string> { "Célula animal", "Célula vegetal", "Célula procariota", "Célula eucariota" },
                        2, "Ciencia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué tipo de radiación es más penetrante?",
                        new List<string> { "Radiación alfa", "Radiación beta", "Radiación gamma", "Luz ultravioleta" },
                        2, "Ciencia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué elemento tiene la mayor electronegatividad?",
                        new List<string> { "Oxígeno", "Cloro", "Flúor", "Nitrógeno" },
                        2, "Ciencia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué nombre recibe el fenómeno de unión de núcleos ligeros para formar uno más pesado?",
                        new List<string> { "Fisión nuclear", "Combustión", "Fusión nuclear", "Ionización" },
                        2, "Ciencia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Cuál es la unidad del campo magnético en el Sistema Internacional?",
                        new List<string> { "Newton", "Tesla", "Henry", "Faradio" },
                        1, "Ciencia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué órgano produce insulina en el cuerpo humano?",
                        new List<string> { "Hígado", "Estómago", "Páncreas", "Riñón" },
                        2, "Ciencia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué tipo de energía se aprovecha en una central hidroeléctrica?",
                        new List<string> { "Nuclear", "Geotérmica", "Cinética del agua", "Solar" },
                        2, "Ciencia"));
                }
           }
            else if (categoria == "Historia")
            {
                if (nivel == "Facil")
                {
                    preguntas.Add(new PreguntaFacil(
                           "¿Quién descubrió América en 1492?",
                           new List<string> { "Cristóbal Colón", "Hernán Cortés", "Marco Polo", "Vasco da Gama" },
                           0, "Historia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿En qué país tuvo lugar la Revolución Francesa?",
                        new List<string> { "Italia", "Alemania", "Francia", "España" },
                        2, "Historia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Cómo se llamaba el primer presidente de Estados Unidos?",
                        new List<string> { "Abraham Lincoln", "Thomas Jefferson", "George Washington", "John Adams" },
                        2, "Historia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿En qué siglo ocurrió la independencia de la mayoría de países latinoamericanos?",
                        new List<string> { "Siglo XVIII", "Siglo XIX", "Siglo XVII", "Siglo XX" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Qué civilización construyó las pirámides de Egipto?",
                        new List<string> { "Romanos", "Mayas", "Egipcios", "Griegos" },
                        2, "Historia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Quién fue el líder del Tercer Reich en Alemania?",
                        new List<string> { "Joseph Stalin", "Adolf Hitler", "Benito Mussolini", "Winston Churchill" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿En qué año terminó la Segunda Guerra Mundial?",
                        new List<string> { "1939", "1945", "1941", "1950" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Qué civilización habitó primero el Imperio del Tahuantinsuyo?",
                        new List<string> { "Aztecas", "Incas", "Mayas", "Toltecas" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Qué gran imperio fue gobernado por Julio César?",
                        new List<string> { "Imperio Bizantino", "Imperio Romano", "Imperio Persa", "Imperio Griego" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Qué famoso líder luchó por la independencia de la India usando la no violencia?",
                        new List<string> { "Martin Luther King", "Jawaharlal Nehru", "Mahatma Gandhi", "Nelson Mandela" },
                        2, "Historia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Qué muro dividió Alemania durante la Guerra Fría?",
                        new List<string> { "Muro de Berlín", "Muro de los Lamentos", "Gran Muralla", "Muro de la Paz" },
                        0, "Historia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Quién fue Simón Bolívar?",
                        new List<string> { "Presidente de México", "Libertador de América", "Rey de España", "Escritor chileno" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿En qué país se originó el Imperio Otomano?",
                        new List<string> { "Egipto", "Turquía", "Grecia", "Arabia Saudita" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Qué acontecimiento ocurrió el 11 de septiembre de 2001 en EE.UU.?",
                        new List<string> { "La caída de la bolsa", "Atentados a las Torres Gemelas", "Huracán Katrina", "Fin de la Guerra Fría" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Quién fue el primer hombre en pisar la Luna?",
                        new List<string> { "Yuri Gagarin", "Buzz Aldrin", "Neil Armstrong", "Alan Shepard" },
                        2, "Historia"));
                }
                else if (nivel == "Medio")
                {
                    preguntas.Add(new PreguntaMedia(
                            "¿Qué tratado puso fin a la Primera Guerra Mundial?",
                            new List<string> { "Tratado de París", "Tratado de Versalles", "Tratado de Utrecht", "Tratado de Viena" },
                            1, "Historia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿En qué año ocurrió la Revolución Rusa?",
                        new List<string> { "1905", "1914", "1917", "1929" },
                        2, "Historia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Cuál fue el imperio dominante en América Central antes de la llegada de los españoles?",
                        new List<string> { "Inca", "Maya", "Romano", "Egipcio" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Quién fue el emperador más famoso del Imperio Napoleónico?",
                        new List<string> { "Luis XIV", "Napoleón Bonaparte", "Carlos V", "Enrique VIII" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué civilización creó un calendario muy avanzado y preciso?",
                        new List<string> { "Griega", "Egipcia", "Maya", "Romana" },
                        2, "Historia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Quién fue el conquistador del Imperio Azteca?",
                        new List<string> { "Francisco Pizarro", "Hernán Cortés", "Cristóbal Colón", "Pedro de Valdivia" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué país colonizó Brasil?",
                        new List<string> { "España", "Francia", "Portugal", "Inglaterra" },
                        2, "Historia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué evento marcó el inicio de la Edad Moderna?",
                        new List<string> { "Caída del Imperio Romano", "Descubrimiento de América", "Revolución Francesa", "Invención de la pólvora" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué ciudad fue dividida por un muro durante la Guerra Fría?",
                        new List<string> { "Múnich", "Praga", "Berlín", "Varsovia" },
                        2, "Historia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Cuál fue la causa principal de la Guerra Fría?",
                        new List<string> { "Disputa territorial", "Conflicto religioso", "Rivalidad ideológica entre EE.UU. y URSS", "Comercio internacional" },
                        2, "Historia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Quién escribió 'El Príncipe', influyendo en la política del Renacimiento?",
                        new List<string> { "Platón", "Maquiavelo", "Rousseau", "Hobbes" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué civilización antigua utilizó la escritura cuneiforme?",
                        new List<string> { "Egipcia", "China", "Sumeria", "Griega" },
                        2, "Historia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué guerra involucró a los Aliados y las Potencias del Eje?",
                        new List<string> { "Guerra de Vietnam", "Primera Guerra Mundial", "Segunda Guerra Mundial", "Guerra de Corea" },
                        2, "Historia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué país fue el último en independizarse en América del Sur?",
                        new List<string> { "Brasil", "Paraguay", "Bolivia", "Surinam" },
                        3, "Historia"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué revolución eliminó la monarquía absoluta en Francia?",
                        new List<string> { "Revolución Industrial", "Revolución Francesa", "Revolución Rusa", "Revolución de Mayo" },
                        1, "Historia"));
                }
                else if (nivel == "Dificil")
                {
                    preguntas.Add(new PreguntaDificil(
                            "¿Qué conflicto bélico es considerado el más largo de la historia?",
                            new List<string> { "Guerra de los Cien Años", "Segunda Guerra Mundial", "Guerra Fría", "Guerra de Vietnam" },
                            0, "Historia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué país inició la Reforma Protestante en el siglo XVI?",
                        new List<string> { "Francia", "Alemania", "Inglaterra", "Italia" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Cuál fue la principal causa de la caída del Imperio Romano de Occidente?",
                        new List<string> { "Revoluciones internas", "Crisis económica", "Invasiones bárbaras", "Cristianismo" },
                        2, "Historia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué reino unificó Italia en el siglo XIX?",
                        new List<string> { "Lombardía", "Cerdeña", "Toscana", "Sicilia" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Quién fue el zar ruso asesinado durante la Revolución Rusa?",
                        new List<string> { "Nicolás II", "Pedro el Grande", "Alejandro III", "Iván IV" },
                        0, "Historia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Cuál fue el líder de la resistencia francesa durante la ocupación nazi?",
                        new List<string> { "Charles de Gaulle", "Winston Churchill", "Georges Clemenceau", "Napoleón III" },
                        0, "Historia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué tratado reconoció la independencia de las Trece Colonias americanas?",
                        new List<string> { "Tratado de Versalles", "Tratado de París (1783)", "Tratado de Utrecht", "Tratado de Gante" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué imperio utilizó una red de caminos llamada 'Qhapaq Ñan'?",
                        new List<string> { "Azteca", "Maya", "Inca", "Olmeca" },
                        2, "Historia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Quién fue el último emperador del Imperio Romano de Oriente (Bizantino)?",
                        new List<string> { "Justiniano", "Constantino XI", "Teodosio", "Arcadio" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué rey inglés fue ejecutado durante la Revolución Inglesa?",
                        new List<string> { "Enrique VIII", "Carlos I", "Jorge III", "Ricardo Corazón de León" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Cuál fue el nombre del plan económico para la reconstrucción de Europa tras la Segunda Guerra Mundial?",
                        new List<string> { "Plan Dawes", "Plan Marshall", "New Deal", "Tratado de Maastricht" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué ciudad fue capital del Imperio Carolingio?",
                        new List<string> { "París", "Roma", "Aquisgrán", "Viena" },
                        2, "Historia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Cuál fue el objetivo principal de las Cruzadas?",
                        new List<string> { "Expandir territorios", "Conquistar Constantinopla", "Recuperar Tierra Santa", "Convertir musulmanes al cristianismo" },
                        2, "Historia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué emperador llevó al Imperio Romano a su máxima expansión?",
                        new List<string> { "César Augusto", "Trajano", "Nerón", "Marco Aurelio" },
                        1, "Historia"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Cuál fue el evento que marcó el inicio de la Edad Contemporánea?",
                        new List<string> { "Caída de Constantinopla", "Independencia de EE.UU.", "Revolución Francesa", "Unificación de Alemania" },
                        2, "Historia"));
                }
            }
            else if (categoria == "Cultura General")
            {
                if (nivel == "Facil")
                {
                    preguntas.Add(new PreguntaFacil(
                            "¿Cuál es el océano más grande del mundo?",
                            new List<string> { "Atlántico", "Índico", "Ártico", "Pacífico" },
                            3, "Cultura General"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Cuántos continentes hay en el mundo?",
                        new List<string> { "5", "6", "7", "8" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Cuál es el país con mayor población del mundo?",
                        new List<string> { "India", "Estados Unidos", "China", "Rusia" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Cuál es el idioma más hablado en el mundo como lengua materna?",
                        new List<string> { "Inglés", "Árabe", "Chino mandarín", "Español" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Qué moneda se utiliza en la mayoría de los países de la Unión Europea?",
                        new List<string> { "Libra esterlina", "Franco suizo", "Euro", "Dólar" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Cuántos días tiene un año bisiesto?",
                        new List<string> { "364", "365", "366", "367" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Qué animal es conocido como el 'rey de la selva'?",
                        new List<string> { "Tigre", "León", "Elefante", "Jaguar" },
                        1, "Cultura General"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Cuál es la capital de México?",
                        new List<string> { "Monterrey", "Guadalajara", "Ciudad de México", "Puebla" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Qué planeta es conocido como el 'planeta rojo'?",
                        new List<string> { "Venus", "Júpiter", "Marte", "Saturno" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Quién pintó la Mona Lisa?",
                        new List<string> { "Miguel Ángel", "Leonardo da Vinci", "Vincent van Gogh", "Pablo Picasso" },
                        1, "Cultura General"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Cuántos colores tiene el arcoíris?",
                        new List<string> { "5", "6", "7", "8" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Cuál es el metal más ligero?",
                        new List<string> { "Cobre", "Litio", "Hierro", "Aluminio" },
                        1, "Cultura General"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Cuál es el país más grande del mundo en extensión?",
                        new List<string> { "Canadá", "China", "Estados Unidos", "Rusia" },
                        3, "Cultura General"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Qué día se celebra la Navidad?",
                        new List<string> { "31 de diciembre", "1 de enero", "24 de diciembre", "25 de diciembre" },
                        3, "Cultura General"));

                    preguntas.Add(new PreguntaFacil(
                        "¿Cuál es el símbolo químico del oro?",
                        new List<string> { "Ag", "Au", "Gd", "Hg" },
                        1, "Cultura General"));
                }
                else if (nivel == "Medio")
                {
                    preguntas.Add(new PreguntaMedia(
                            "¿Cuál es la capital de Australia?",
                            new List<string> { "Sídney", "Melbourne", "Canberra", "Brisbane" },
                            2, "Cultura General"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué escritor es autor de Cien años de soledad?",
                        new List<string> { "Mario Vargas Llosa", "Julio Cortázar", "Gabriel García Márquez", "Pablo Neruda" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué científico desarrolló la teoría de la relatividad?",
                        new List<string> { "Isaac Newton", "Galileo Galilei", "Nikola Tesla", "Albert Einstein" },
                        3, "Cultura General"));

                    preguntas.Add(new PreguntaMedia(
                        "¿En qué país se encuentra la torre inclinada de Pisa?",
                        new List<string> { "Francia", "Grecia", "Italia", "España" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Cuál es el río más largo del mundo?",
                        new List<string> { "Amazonas", "Nilo", "Yangtsé", "Misisipi" },
                        0, "Cultura General"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué país tiene forma de bota en el mapa?",
                        new List<string> { "Chile", "India", "Italia", "Mexico" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaMedia(
                        "¿En qué continente está ubicada la cordillera del Himalaya?",
                        new List<string> { "América", "Asia", "Europa", "África" },
                        1, "Cultura General"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué artista pintó el techo de la Capilla Sixtina?",
                        new List<string> { "Leonardo da Vinci", "Rafael", "Miguel Ángel", "Donatello" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué gas necesitan las plantas para realizar la fotosíntesis?",
                        new List<string> { "Oxígeno", "Hidrógeno", "Dióxido de carbono", "Nitrógeno" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Cuál es la capital de Canadá?",
                        new List<string> { "Toronto", "Vancouver", "Ottawa", "Montreal" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué país es famoso por el Taj Mahal?",
                        new List<string> { "Arabia Saudita", "India", "Egipto", "Tailandia" },
                        1, "Cultura General"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué filósofo griego fue maestro de Alejandro Magno?",
                        new List<string> { "Platón", "Aristóteles", "Sócrates", "Pitágoras" },
                        1, "Cultura General"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué país tiene más premios Nobel de la Paz?",
                        new List<string> { "Noruega", "Alemania", "Estados Unidos", "Japón" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Cuál es el idioma oficial de Brasil?",
                        new List<string> { "Español", "Portugués", "Inglés", "Francés" },
                        1, "Cultura General"));

                    preguntas.Add(new PreguntaMedia(
                        "¿Qué instrumento mide los terremotos?",
                        new List<string> { "Telescopio", "Sismógrafo", "Termómetro", "Barómetro" },
                        1, "Cultura General"));
                }
                else if (nivel == "Dificil")
                {
                    preguntas.Add(new PreguntaDificil(
                             "¿Cuál es el país más joven del mundo reconocido oficialmente?",
                             new List<string> { "Kosovo", "Sudán del Sur", "Timor Oriental", "Eritrea" },
                             1, "Cultura General"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué escritor ganó el Premio Nobel de Literatura en 2021?",
                        new List<string> { "Kazuo Ishiguro", "Olga Tokarczuk", "Abdulrazak Gurnah", "Peter Handke" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué elemento químico tiene el número atómico 92?",
                        new List<string> { "Uranio", "Plomo", "Mercurio", "Radio" },
                        0, "Cultura General"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Cuál es el idioma con más palabras registradas en su diccionario?",
                        new List<string> { "Español", "Alemán", "Francés", "Inglés" },
                        3, "Cultura General"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué ciudad es considerada la más antigua habitada continuamente?",
                        new List<string> { "Atenas", "Jerusalén", "Damasco", "El Cairo" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Cuál es el lago navegable más alto del mundo?",
                        new List<string> { "Titicaca", "Baikal", "Victoria", "Ness" },
                        0, "Cultura General"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué país tiene la bandera más antigua aún en uso?",
                        new List<string> { "Reino Unido", "Japón", "Dinamarca", "China" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Quién compuso la ópera La flauta mágica?",
                        new List<string> { "Beethoven", "Mozart", "Bach", "Chopin" },
                        1, "Cultura General"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué filósofo es considerado el padre del empirismo moderno?",
                        new List<string> { "Descartes", "Hume", "Locke", "Kant" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué científico propuso la clasificación binomial para los seres vivos?",
                        new List<string> { "Darwin", "Lamarck", "Linneo", "Mendel" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Cuál es la montaña más alta fuera de Asia?",
                        new List<string> { "Aconcagua", "Kilimanjaro", "Denali", "Elbrús" },
                        0, "Cultura General"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Qué compositor es autor de la obra Carmina Burana?",
                        new List<string> { "Wagner", "Carl Orff", "Mahler", "Schubert" },
                        1, "Cultura General"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Cuál es el gentilicio de alguien nacido en Catar?",
                        new List<string> { "Catarense", "Catarino", "Catarí", "Cataríano" },
                        2, "Cultura General"));

                    preguntas.Add(new PreguntaDificil(
                        "¿Cuál es el país con más islas en el mundo?",
                        new List<string> { "Filipinas", "Indonesia", "Canadá", "Suecia" },
                        3, "Cultura General"));
                }
            }

            if (preguntas.Count == 0)
                throw new InvalidOperationException("No hay preguntas disponibles para la combinación seleccionada");

            return preguntas[random.Next(preguntas.Count)];
        }
    }
}
