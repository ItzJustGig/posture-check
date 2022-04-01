using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posturecheck
{
    class Themes
    {
        public struct Theme
        {
            public string nome;
            public string postureSound;
            public string breakSound;
            public string img;
        }

        List<Theme> themes = new List<Theme>();

        public Themes()
        {
            Theme temp = new Theme();
            temp.nome = "Default";
            temp.postureSound = "\\default\\posture.wav";
            temp.breakSound = "\\default\\break.wav";
            temp.img = "\\default\\img.png";

            themes.Add(temp);
        }

        public List<Theme> GetThemes ()
        {
            return themes;
        }

        public Theme GetThemes(int id)
        {
            for (int i = 0; i < themes.Count; i++)
            {
                if (i == id)
                    return themes[i];
            }
            return themes[0];
        }

        public int SizeList()
        {
            return themes.Count;
        }

        public void CreateTheme(string nome, string posture, string breakS)
        {
            Theme temp = new Theme();
            temp.nome = nome;
            temp.postureSound = posture;
            temp.breakSound = breakS;

            themes.Add(temp);
        }

        public void CreateTheme(string nome, string posture, string breakS, string img)
        {
            Theme temp = new Theme();
            temp.nome = nome;
            temp.postureSound = posture;
            temp.breakSound = breakS;
            temp.img = img;

            themes.Add(temp);
        }

    }
}
