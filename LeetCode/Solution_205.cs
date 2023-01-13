namespace LeetCode;

public class Solution_205 {
    public bool IsIsomorphic(string s, string t) {
        int i = 0;

        if(s.Length != t.Length)
            return false;
        
        Dictionary<char,char> map = new Dictionary<char,char>();
        while( i<s.Length){            
            bool keyExists = map.ContainsKey(s[i]);

            if(!keyExists)
                map.Add(s[i], t[i]);
            
            var maped = map[s[i]];
            
            if(keyExists && maped != t[i])
                return false; 

            bool valueExists = map.ContainsValue(t[i]);
            var saved = map.First(x => x.Value == t[i]);
            if(valueExists && s[i] != saved.Key)
                return false; 

            i++;           
        }

        return true;
    }
}