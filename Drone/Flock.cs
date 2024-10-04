

public class Flock
{
    Drone[] agents;
    int num;

    public Flock(int maxnum)
    {
        agents = new Drone[maxnum];
    }

    // actually add the drones
    public void Init(int num)
    {
        this.num = num;
        for (int i = 0; i < num; i++)
        {
            agents[i] = new Drone(i);        }
    }

    public void Update()
    {
        for (int i = 0; i < num; i++)
        {
            agents[i].Update();
        }
    }

    public float average()
    {
        if (num == 0) return 0;

        float sum = 0;
        for (int i = 0; i < num; i++)
        {
            sum += agents[i].ID; 
        }
        return sum / num;
    }

    public int max()
    {
        if (num == 0) return 0;

        int maxValue = agents[0].ID;
        for (int i = 1; i < num; i++)
        {
            if (agents[i].ID > maxValue)
            {
                maxValue = agents[i].ID;
            }
        }
        return maxValue;
    }
    
    public int min()
    {
        if (num == 0) return 0;

        int minValue = agents[0].ID;
        for (int i = 1; i < num; i++)
        {
            if (agents[i].ID < minValue)
            {
                minValue = agents[i].ID;
            }
        }
        return minValue;
    }

    public void print()
    {
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("Drone ID: " + agents[i].ID);
        }
    }

    public void append(Drone val)
    {
        if (num < agents.Length)
        {
            agents[num] = val;
            num++;
        }
    }

    public void appendFront(Drone val)
    {
        if (num < agents.Length)
        {
            for (int i = num; i > 0; i--)
            {
                agents[i] = agents[i - 1];
            }
            agents[0] = val;
            num++;
        }
    }


    public void insert(Drone val, int index)
    {
        if (num < agents.Length && index >= 0 && index <= num)
        {
            for (int i = num; i > index; i--)
            {
                agents[i] = agents[i - 1];
            }
            agents[index] = val;
            num++;
        }

    }

    public void deleteFront(int index)
    {
        if (num > 0)
        {
            for (int i = 0; i < num - 1; i++)
            {
                agents[i] = agents[i + 1];
            }
            num--;
        }
    }

    public void deleteBack(int index)
    {
        if (num > 0)
        {
            agents[num - 1] = null;
            num--;
        }

    }


    public void delete(int index)
    {
        if (index >= 0 && index < num)
        {
            for (int i = index; i < num - 1; i++)
            {
                agents[i] = agents[i + 1];
            }
            num--;
        }
    }


    public void bubblesort()
    {
        for (int i = 0; i < num - 1; i++)
        {
            for (int j = 0; j < num - i - 1; j++)
            {
                if (agents[j].ID > agents[j + 1].ID)
                {
                    Drone temp = agents[j];
                    agents[j] = agents[j + 1];
                    agents[j + 1] = temp;
                }
            }
        }
    }

    public void insertionsort()
    {        for (int i = 1; i < num; i++)
        {
            Drone key = agents[i];
            int j = i - 1;

            while (j >= 0 && agents[j].ID > key.ID)
            {
                agents[j + 1] = agents[j];
                j = j - 1;
            }
            agents[j + 1] = key;
        }
    }
}
