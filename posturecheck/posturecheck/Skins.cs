using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posturecheck
{
    class Skins
    {
        public struct Skin
        {
            public string nome;
            public string postureSound;
            public string breakSound;
            public string img;
        }

        List<Skin> skins = new List<Skin>();

        public Skins()
        {
            Skin temp = new Skin();
            temp.nome = "Default";
            temp.postureSound = "\\default\\posture.wav";
            temp.breakSound = "\\default\\break.wav";
            temp.img = "\\default\\img.png";

            skins.Add(temp);
        }

        public List<Skin> GetSkins ()
        {
            return skins;
        }

        public Skin GetSkins(int id)
        {
            for (int i = 0; i < skins.Count; i++)
            {
                if (i == id)
                    return skins[i];
            }
            return skins[0];
        }

        public void SetSkin(string nome, string posture, string breakS)
        {
            Skin temp = new Skin();
            temp.nome = nome;
            temp.postureSound = posture;
            temp.breakSound = breakS;

            skins.Add(temp);
        }

        public void SetSkin(string nome, string posture, string breakS, string img)
        {
            Skin temp = new Skin();
            temp.nome = nome;
            temp.postureSound = posture;
            temp.breakSound = breakS;
            temp.img = img;

            skins.Add(temp);
        }

    }
}
