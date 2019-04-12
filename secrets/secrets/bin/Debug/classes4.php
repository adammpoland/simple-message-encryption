<?php
echo "PHP Class Info part 3<br>";

/*
__set
__get
__isset
__unset
*/

class testClass {
	private $data = array();
	private $author;
	public function __set($name, $value) {
		$this->data[$name] = $value;
	}
	
	public function __get($name) {
		return $this->data[$name];
	}
	
	public function setAuthor($name) {
		//$this->data['author'] = $name;
		$this->author = $name;
	}
	
	public function __isset($name) {
		return isset($this->data[$name]);
	}
	
	public function __unset($name) {
		unset($this->data[$name]);
	}
	
	public function __toString() {
		return $this->author . ", " . $this->data['title'];
	}	
}

$theTest = new testClass();

$theTest->title = "Dictionary";
$theTest->setAuthor("Webster");


if (isset($theTest->title)) {
	echo "We have a title<BR>";
}

echo $theTest;
?>