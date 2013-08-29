        string input = tb_input.Text;
        string[] arr = new string[input.Length];
        List<string> li = new List<string>();
        arr = input.Split(' ');
        Random r = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            int index = r.Next(i, arr.Length);
            li.Add(arr[index]);
            string temp = arr[index]; // swap
            arr[index] = arr[i];
            arr[i] = temp;

        }
        string result = "";
        foreach (string value in li)
        {
            result = result + value + " ";
        }
        result.TrimEnd();
        tb_output.Text = result.ToString();
