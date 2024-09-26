using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

public class CalcolatoreModel : PageModel
{
    [BindProperty]
    public float x1 { get; set; }
    [BindProperty]
    public float y1 { get; set; }
    [BindProperty]
    public float x2 { get; set; }
    [BindProperty]
    public float y2 { get; set; }
    public float? Distanza { get; set; }

    public void OnPost()
    {
        Distanza = CalcolaDistanza(x1, y1, x2, y2);
    }

    private float CalcolaDistanza(float x1, float y1, float x2, float y2)
    {
        return (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}
