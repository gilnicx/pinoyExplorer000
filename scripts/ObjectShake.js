

public var speed = 50F; 
public var amount = 1.0F;

function Update()
  {
    transform.position.x = Mathf.Sin(Time.time * speed);

  }