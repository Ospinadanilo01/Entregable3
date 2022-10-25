namespace PageProducts.Data;


public class UsuarioData
{
    private List<string> Nombre = new List<string>(){
        
    };

    private List<string> Correoo = new List<string>(){
        
    };
    private List<string> Mensaje = new List<string>(){
        
    };

    private List<string> Numero = new List<string>(){
        
    };
   
    public List<Usuario> GetUsuarios ()
    {
        List<Usuario> ListUsuario = new ();
    
        
            Usuario item = new Usuario {
                Correo = this.Correoo.ToString(),
                Nombre = this.Nombre.ToString(),
                Mensaje = this.Mensaje.ToString(),
                Numero = this.Numero.ToString()
            };
            ListUsuario.Add(item);
        

        return ListUsuario;
    }
}