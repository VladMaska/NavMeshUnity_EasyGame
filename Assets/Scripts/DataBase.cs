using UnityEngine;

namespace WhiteWolf {

    public class DataBase : MonoBehaviour {

        // Load FLOAT
        public float LoadDataFloat( string name ) {
            if ( PlayerPrefs.HasKey( name ) ) return PlayerPrefs.GetFloat( name );
            else SaveDataFloat( name, -0.0f );
            return -0.0f;
        }

        // Load INT
        public int LoadDataInt( string name ) {
            if ( PlayerPrefs.HasKey( name ) ) return PlayerPrefs.GetInt( name );
            else SaveDataInt( name, -0 );
            return -0;
        }

        // Load STRING
        public string LoadDataString( string name ) {
            if ( PlayerPrefs.HasKey( "login" ) ) return PlayerPrefs.GetString( name );
            else SaveDataString( name, null );
            return null;
        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        // Save FLOAT
        public void SaveDataFloat( string name, float value ) {
            PlayerPrefs.SetFloat( name, value ); PlayerPrefs.Save();
        }

        // Save INT
        public void SaveDataInt( string name, int value ) {
            PlayerPrefs.SetInt( name, value );
            PlayerPrefs.Save();
        }

        // Save STRING
        public void SaveDataString( string name, string value ) {
            PlayerPrefs.SetString( name, value );
            PlayerPrefs.Save();
        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        // Check FLOAT
        public bool CheakFloat( string name ){

            if ( LoadDataFloat( name ) == -0f ) return false;
            else return true;

        }

        // Check INT
        public bool CheakInt( string name ){

            if ( LoadDataInt( name ) == -0f ) return false;
            else return true;

        }

        // Check STRING
        public bool CheakString( string name ){

            if ( LoadDataString( name ) == null ) return false;
            else return true;

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        // Reset INT / FLOAT / STRING
        public void ResetData() {
            PlayerPrefs.DeleteAll();
            Debug.Log( "All data deleted!" );
        }

    }

    //public class Library : MonoBehaviour { }

}