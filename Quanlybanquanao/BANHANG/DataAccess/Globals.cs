using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace DataAccess
{
    public class Globals
    {
        // Methods
        public static ArrayList ConvertArrayList(IDataReader drReader)
        {
            ArrayList list = new ArrayList();
            while ((drReader != null) && drReader.Read())
            {
                Hashtable hashtable = new Hashtable();
                for (int i = 0; i < drReader.FieldCount; i++)
                {
                    if (!hashtable.Contains(drReader.GetName(i)))
                    {
                        if ((drReader.IsDBNull(i) || (drReader[i] == null)) || (drReader[i].ToString() == string.Empty))
                        {
                            hashtable.Add(drReader.GetName(i).ToUpper(), string.Empty);
                        }
                        else
                        {
                            hashtable.Add(drReader.GetName(i), drReader[i]);
                        }
                    }
                }
                list.Add(hashtable);
            }
            return list;
        }

        public static Hashtable ConvertHashTable(IDataReader drReader)
        {
            Hashtable hashtable = new Hashtable();
            if (drReader.Read())
            {
                for (int i = 0; i < drReader.FieldCount; i++)
                {
                    if (!hashtable.Contains(drReader.GetName(i)))
                    {
                        if ((drReader[i] == null) || drReader.IsDBNull(i))
                        {
                            hashtable.Add(drReader.GetName(i).ToUpper(), string.Empty);
                        }
                        else
                        {
                            hashtable.Add(drReader.GetName(i), drReader[i]);
                        }
                    }
                }
            }
            return hashtable;
        }

        // Nested Types
        public enum DATATYPE
        {
            NUMBER,
            CHAR,
            VARCHAR,
            NVARCHAR,
            NTEXT,
            BINARY,
            BLOB,
            CLOB,
            NCLOB
        }

    }
}
