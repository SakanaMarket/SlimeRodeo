using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Management : MonoBehaviour
{
    [SerializeField] private int total_collected;
    [SerializeField] private int death_toll;
    [SerializeField] Text t;
    [SerializeField] GameObject next;
    [SerializeField] int endCount;

    private void Awake()
    {
        total_collected = 0;
        death_toll = 0;
    }

    private void Update()
    {
        Debug.Log(total_collected);
        EndGame();
    }

    public void increment_count()
    {
        total_collected += 1;
    }

    public void ResetCount()
    {
        total_collected = 0;
    }

    public int GetCount()
    {
        return total_collected;
    }

    public void increment_death()
    {
        death_toll += 1;
    }

    public int GetDeath()
    {
        return death_toll;
    }

    private void EndGame()
    {
        if (total_collected >= endCount)
        {
            if (death_toll == 0)
            {
                t.text = "GREAT JOB!\nYou've Instructed Gabe Flawlessly!";
            }
            else
            {
                t.text = "NICE!\nBut you could do Better!";
            }
            if (next != null)
            {
                next.SetActive(true);
            }
            
        }
        
    }

}
