using PdfSharp.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario_parcial
{
    public class FontResolver : IFontResolver
    {
        public byte[] GetFont(string faceName)
        {
            
            if (faceName.Equals("Arial", StringComparison.OrdinalIgnoreCase))
            {
                string rutaFuenteArial = @"C:\Windows\Fonts\arial.ttf";
                return File.ReadAllBytes(rutaFuenteArial);
            }

            return null; 
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            
            return new FontResolverInfo(familyName);
        }
    }
}
