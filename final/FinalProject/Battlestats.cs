public abstract class Battlestats:Methods
{
    private int _shield = 5;

    private int _transport = 5;

    private int _guns = 5;

    private int _defense = 5;

    private int _artillery = 5;

    public Battlestats(int shield, int transport, int guns, int defense, int artillery)
    {
        _shield = shield;

        _transport = transport;

        _guns = guns;
        
        _defense = defense;

        _artillery = artillery;

    }

    public int GetShield()
    {
        return _shield;
    }

    public void SetShield(int shield)
    {
        _shield = shield;
    }

    public int GetTransport()
    {
        return _transport;
    }

    public void SetTransport(int transport)
    {
        _transport = transport;
    }

    public int GetGuns()
    {
        return _guns;
    }

    public void SetGuns(int guns)
    {
        _guns = guns;
    }

    public int GetDefense()
    {
        return _defense;
    }

    public void SetDefense(int defense)
    {
        _defense = defense;
    }

    public int GetArtillery()
    {
        return _artillery;
    }

    public void SetArtillery(int artillery)
    {
        _artillery = artillery;
    }
}

