using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagUtility : MonoBehaviour {

	public static string getParentTagName(string name) {
        int pos = name.IndexOf("/");
 
        if (0 < pos) {
            return name.Substring(0, pos);
        } else {
            return name;
        }
    }
 
    public static string getParentTagName(GameObject gameObject) {
        string name = gameObject.tag;
        int pos = name.IndexOf("/");
 
        if (0 < pos) {
            return name.Substring(0, pos);
        } else {
            return name;
        }
    }
 
    public static string getChildTagName(string name) {
        int pos = name.IndexOf("/");
 
        if (0 < pos) {
            return name.Substring(pos + 1);
        } else {
            return name;
        }
    }
 
    public static string getChildTagName(GameObject gameObject) {
        string name = gameObject.tag;
        int pos = name.IndexOf("/");
 
        if (0 < pos) {
            return name.Substring(pos + 1);
        } else {
            return name;
        }
    }


	
}
