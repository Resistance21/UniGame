	function OnTriggerEnter (other : Collider) {
		if(other.tag == "GravityBot1"){
		//GetComponent("PlayerGravityBody12").enabled = false;
		//GetComponent("PlayerGravityBody11").enabled = false;
		//GetComponent("PlayerGravityBody10").enabled = false;
		//GetComponent("PlayerGravityBody9").enabled = false;
		//GetComponent("PlayerGravityBody8").enabled = false;s
		//GetComponent("PlayerGravityBody7").enabled = false;
		//GetComponent("PlayerGravityBody6").enabled = false;
		//GetComponent("PlayerGravityBody5").enabled = false;
		//GetComponent("PlayerGravityBody4").enabled = false;
		//GetComponent("PlayerGravityBody3").enabled = false;
		GetComponent("PlayerGravityBody").enabled = true;
		GetComponent("PlayerGravityBody2").enabled = false;
		
	
		
		//GetComponent(FauxGravityAttractor).enabled = false;
		//GetComponent(FauxGravityAttractor2).enabled = true;
		//FauxGravityAttractor.enabled = false;
		//FauxGravityAttractor2.enabled = true;    
    //function OnTriggerEnter( other : Collider ) {
    //other.transform.position = targetPosition;
    //
    }
    }
    