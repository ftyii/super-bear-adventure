// Exemplo de verificação do botão de seleção/confirmação
void Update()
{
    // Verifica se o botão "OK/Submit" do controle foi pressionado
    if (Input.GetButtonDown("Submit"))
    {
        if (estaoNoMenuInicial)
        {
            IniciarJogo();
        }
        else if (proximoDeObjetoInterativo)
        {
            InteragirComObjeto();
        }
    }
}
