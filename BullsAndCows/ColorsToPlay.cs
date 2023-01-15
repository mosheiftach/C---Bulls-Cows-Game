using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    public class ColorsToPlay
    {
        private readonly int m_Count = 8;
        private readonly Color m_ColorRed = Color.Red;
        private readonly Color m_ColorAqua = Color.Aqua;
        private readonly Color m_ColorPurple = Color.Purple;
        private readonly Color m_ColorDarkSlateGary = Color.DarkSlateGray;
        private readonly Color m_ColorGreenShade = Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
        private readonly Color m_ColorPinkShade = Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (255)))));
        private readonly Color m_ColorOrangeShade = Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
        private readonly Color m_ColorBlue = Color.Blue;

        public int Count
        {
            get { return this.m_Count; }
        }

        public Color Blue
        {
            get { return this.m_ColorBlue; }
        }

        public Color Red
        {
            get { return this.m_ColorRed; }
        }

        public Color DarkSlateGray
        {
            get { return this.m_ColorDarkSlateGary; }
        }

        public Color Green
        {
            get { return this.m_ColorGreenShade; }
        }

        public Color Pink
        {
            get { return this.m_ColorPinkShade; }
        }

        public Color Purple
        {
            get { return this.m_ColorPurple; }
        }

        public Color Orange
        {
            get { return this.m_ColorOrangeShade; }
        }

        public Color Aqua
        {
            get { return this.m_ColorAqua; }
        }
    }
}
