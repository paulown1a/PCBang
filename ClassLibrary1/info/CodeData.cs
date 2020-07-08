using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbdata
{
    public class CodeData : EntitiyData<Code>
    {
        public Code Get(int codeId)
        {
            PCUIEntities context = CreateContext();
            return context.Codes.FirstOrDefault(a => a.CodeID == codeId);
        }

        public void Delete(int codeId)
        {
            Code code = Get(codeId);
            if (code == null)
                return;
            Delete(code);
        }
    }
}
