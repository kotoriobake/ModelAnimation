using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Windows.Forms; //OpenFileDialog用に使う
using System.IO;

public class OpenCsvFile : MonoBehaviour
{
    public Text text;

    public void OpenExistFile()
    {
        OpenFileDialog open_file_dialog = new OpenFileDialog();

        //csvファイルを開くことを指定する
        open_file_dialog.Filter = "csvファイル|*.csv";

        //ファイルが実在しない場合は警告を出す(true)、警告を出さない(false)
        open_file_dialog.CheckFileExists = false;

        //ダイアログを開く
        open_file_dialog.ShowDialog();

        //取得したファイル名をInputFieldに代入する
        Debug.Log(open_file_dialog.FileName);

        using (StreamReader sr = new StreamReader(open_file_dialog.FileName))
        {
            var str = sr.ReadToEnd();
            Debug.Log(str);
            text.text = str;
        }
    }
}
