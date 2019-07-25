# Sine-
sin wave 

#### sinでゆらゆらWave 
![Sine](https://user-images.githubusercontent.com/43961147/61839923-5be6f400-aeca-11e9-9b2c-0a1a55fb19c5.gif)
*** 

forで生産してforeachの中でiの値を利用してズレを作成。

        for (int j = 0; j < Amount; j++)
        {
            for (int i = 0; i < Amount; i++)
            {
            prefabsballs[i, j] = Instantiate(prefabboal, new Vector3(j * 3, 0, i * step), Quaternion.identity);
            }
        };


        		   foreach (var boxcube in GameObject_cube.prefabsballs)
        {
            theta = (boxcube.transform.position.z + 1) + Time.time * speed;

            radian = Mathf.Deg2Rad * theta * sinHight;

            float sin = Mathf.Sin(radian);

           boxcube.transform.position = new Vector3(boxcube.transform.position.x, sin, boxcube.transform.position.z);
        }
