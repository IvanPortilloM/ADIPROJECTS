using System;
using System.Collections.Generic;
using System.Text;

namespace CheckComboBoxTest {
    public class CCBoxItem1 {
        private int val;
        public int Value {
            get { return val; }
            set { val = value; }
        }
        
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public CCBoxItem1() {
        }

        public CCBoxItem1(string name, int val) {
            this.name = name;
            this.val = val;
        }

        public override string ToString() {
         //   return string.Format("name: '{0}', value: {1}", name, val);
            return string.Format("{0}", name);
        }
    }
}
