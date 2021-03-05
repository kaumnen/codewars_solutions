public class DnaStrand 
    {
        public static string MakeComplement(string dna)
        {
            string result = "";
            
            foreach(char s in dna)
            {
              
              switch(s)
              {
                case 'A':
                  result += 'T';
                  break;
                  
                case 'T':
                  result += 'A';
                  break;
                  
                case 'C':
                  result += 'G';
                  break;
                  
                default:
                  result += 'C';
                  break;
              }
            }
          
            return result;
        }
    }
