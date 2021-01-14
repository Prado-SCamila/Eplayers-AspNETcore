using System.IO;
using System.Collections.Generic;


namespace Eplayers_AspNETcore.Models
{
    public class EplayersBase
    {
        public void CreateFolderAndFile(string _path);

        string folder = _path.Split("/")[0];

        if(!Directory.Exists(folder)){

            Directory.CreateDirectory(folder)
        }

        if(!File.Exists(_path)){
            
        }
    }
    }
