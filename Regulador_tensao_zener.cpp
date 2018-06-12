#include <iostream>

using namespace std;

class Circuit {

public:
    float vi, i;
    float ps, rs, rl, pl, vo;

    Circuit(float _vi, float _i, float _ps, float _rs, float _rl, float _pl, float _vo):
    vi(_vi), i(_i), ps(_ps), rs(_rs), rl(_rl), pl(_pl), vo(_vo){};
    ~Circuit() {}

    float getVI() const {return vi;}
    float getI () const {return i;}
    float getRS() const {return rs;}
    float getPS() const {return ps;}
    float getRL() const {return rl;}
    float getPL() const {return pl;}

    void setVI(const float& vi) {this->vi = vi;}
    void setI (const float& i)  {this->i = i;}
    void setRS(const float& rs) {this->rs = rs;}
    void setPS(const float& rs) {this->ps = ps;}
    void setRL(const float& rl) {this->rl = rl;}
    void setPL(const float& pl) {this->pl = pl;}
};

class Zener: public Circuit {
    float vz, iz;

public:
    Zener(float _vz, float _iz, float _vi, float _i, float _ps, float _rs, float _rl, float _pl, float _vo):
    vz(_vz), iz(_iz), Circuit(_vi,_i,_ps,_rs,_rl,_pl,_vo){};
    ~Zener() {}

    float getVZ() const {return vz;}
    float getIZ() const {return iz;}

    void setVZ(const float& vz) {this->vz = vz; }
    void setIZ(const float& iz) {this->iz = iz; }

    float calculateSeriesResistance() {
        return rs = (vi-vz)/i;
    }
    float calculatePowerDissipateSeriesRes(){
        return ps = i * i * rs;
    }
    float calculateZenerCurrent() {
        return iz = ((vi-vz)/rs) - (vz/rl);
    }
    float calculatePowerDissipateLoadRes(){
        return pl = (i-iz) * (i-iz) * rl;
    }
    float calculateOutputVoltage(){
        return vo = (i-iz) * rl;
    }
};

int main()
{
  float vz, iz, vi, i, ps, rs, rl, pl, vo;

	cout << "Enter the value of input voltage in volts: " << endl;
	cin >> vi;

	cout << "\nEnter the value of Zener voltage in volts: "  << endl;
	cin >> vz;

	cout << "\nEnter the value of total current i in milliampere: " << endl;
    cin >> i;

    cout << "\nEnter the value of load resistance in k Ohms: " << endl;
	cin >> rl;

    Zener z(vz, iz, vi, i, ps, rs, rl, pl, vo);

    cout << "\nValue of series resistance is: "
        << z.calculateSeriesResistance() << " k Ohms" << endl;

    cout << "\nPower dissipated across series resistance is: "
        << z.calculatePowerDissipateSeriesRes() << " mW" << endl;

    cout << "\nZener current is: "
        << z.calculateZenerCurrent() << " mA" << endl;

    cout << "\nPower dissipated across load resistance is: "
        << z.calculatePowerDissipateLoadRes() << " mW" << endl;

    cout << "\nOutput voltage is: "
        << z.calculateOutputVoltage() << " V" << endl;

  return 0;
}
