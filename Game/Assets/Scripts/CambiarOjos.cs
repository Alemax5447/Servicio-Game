using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarOjos : MonoBehaviour
{
    public GameObject ojos1;
	public GameObject ojos2;
	public GameObject ojos3;
	public GameObject ojos4;
	public GameObject buttonOjo1,buttonOjo2,buttonOjo3,buttonOjo4;

	public int numeroOjo=0;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void adelante()
	{
		numeroOjo++;
		pushOjos();
		if(numeroOjo==6)
		{
			numeroOjo=0;
		}
	}
	public void atras()
	{
		if(numeroOjo==0)
		{
			numeroOjo=5;
		}
		numeroOjo--;
		pushOjos();
	}
	public void pushOjos()
	{	

		
		if(numeroOjo==1)
		{
		buttonOjo1.SetActive(true);
		buttonOjo2.SetActive(false);
		buttonOjo3.SetActive(false);
		buttonOjo4.SetActive(false);

		ojos1.SetActive(true);
		 ojos2.SetActive(false);
		 ojos3.SetActive(false);
		 ojos4.SetActive(false);
		}
		
		if(numeroOjo==2)
		{
		buttonOjo1.SetActive(false);
		buttonOjo2.SetActive(true);
		buttonOjo3.SetActive(false);
		buttonOjo4.SetActive(false);

		 ojos1.SetActive(false);
		 ojos2.SetActive(true);
		 ojos3.SetActive(false);
		 ojos4.SetActive(false);
		}
		if(numeroOjo==3)
		{

		buttonOjo1.SetActive(false);
		buttonOjo2.SetActive(false);
		buttonOjo3.SetActive(true);
		buttonOjo4.SetActive(false);

		 ojos1.SetActive(false);
		 ojos2.SetActive(false);
		 ojos3.SetActive(true);
		 ojos4.SetActive(false);
		}
		if(numeroOjo==4)
		{
		ojos1.SetActive(false);
		 ojos2.SetActive(false);
		 ojos3.SetActive(false);
		 ojos4.SetActive(true);

		 buttonOjo1.SetActive(false);
		 buttonOjo2.SetActive(false);
		 buttonOjo3.SetActive(false);
		 buttonOjo4.SetActive(true);
		 
		}
		if(numeroOjo==5)
		{
		 ojos1.SetActive(false);
		 ojos2.SetActive(false);
		 ojos3.SetActive(false);
		 ojos4.SetActive(false);
		 
		}
		 
	}
	
}
