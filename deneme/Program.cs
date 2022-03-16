string s = "12:01:00PM";

string added12Hours = (Convert.ToInt32((s[0].ToString() + s[1].ToString())) + 12).ToString();
if (s.Contains("PM") || s.Contains("pm"))//before the afternoon
{
    if (Convert.ToInt32(added12Hours) >= 24)
    {
        added12Hours = (Convert.ToInt32(added12Hours) - 24).ToString();
    }
    else{
        added12Hours=added12Hours+s.Substring(2,6);
    }
        Console.WriteLine(added12Hours + s.Substring(2, 6));
    
}
else if(s.Contains("AM") || s.Contains("am"))//after the afternoon
{
    Console.WriteLine(added12Hours+s.Substring(0,8));   
}