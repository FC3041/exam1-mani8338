namespace Exam1;


public class Q8ComparableString: IComparable<string>
{
    public string s;
    public int CompareTo(string ss)
    {
        if(s == null && ss != null){
            return -1;
        }else if(s != null && ss == null){
            return 1;
        }
        else if(s.Length != ss.Length){
            return s.Length.CompareTo(ss.Length);
        }else{
            return s.CompareTo(ss);
        }
    }
    public void Compare(string s1,string s2)
    {
        s1.CompareTo(s2);
    }
}

