
/*

Banda bandaQueen = new Banda("Queen");

Album albumDoQueen = new Album("A Night at the Opera");

Musica musica1 = new Musica(bandaQueen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = true
};


Musica musica2 = new Musica(bandaQueen, "Love of My Life")
{
    Duracao = 354,
    Disponivel = false
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

musica1.ExibirFichaTecnia();
musica2.ExibirFichaTecnia();

albumDoQueen.ExibirMusicasDoAlbum();
bandaQueen.AdicionarAlbum(albumDoQueen);
bandaQueen.ExibirAlbumsDaBanda();

*/

Episodios episodio1 = new(60, 1, "Técinicas de facilitação");
episodio1.AdicionarConvidado("João");
episodio1.AdicionarConvidado("Maria");

Episodios episodio2 = new(90, 2, "Técinicas de aprendizado");
episodio2.AdicionarConvidado("Fernando");
episodio2.AdicionarConvidado("Guilherme");

Podcast podcast = new("Gabriel", "Aprendizado Ágil");
podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.ExibirDetalhesPodcast();